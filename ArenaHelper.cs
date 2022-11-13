using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaHelper
{
    public partial class ArenaHelper : Form
    {
        public static string addressglobal;
        public ArenaHelper(string address)
        {
            addressglobal = address;
            InitializeComponent();
            CurrentBlock.RunWorkerAsync();
            LastAttack.RunWorkerAsync();
            differenceworker.RunWorkerAsync();
        }

        private async Task ArenaHelper_GetCurrentBlock()
        {
            while (true)
            {
                var client = new RestClient("https://api.9cscan.com/blocks/");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
                var resultObjects = AllChildren(JObject.Parse(response.Content))
                    .First(c => c.Type == JTokenType.Array && c.Path.Contains("blocks"))
                    .Children<JObject>();

                var first = resultObjects.First();
                var blockcount = first["index"];
                Helper.SetText(this, this.currentBlockLBL, blockcount.ToString());

                Thread.Sleep(3000);
            }
        }

        private async Task ArenaHelper_GetLastAttack()
        {
            while (true)
            {
                var client = new RestClient("https://api.9cscan.com/accounts/"+addressglobal+"/transactions/");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);
                Console.WriteLine(response.Content);
                var resultObjects = AllChildren(JObject.Parse(response.Content))
                    .First(c => c.Type == JTokenType.Array && c.Path.Contains("transactions"))
                    .Children<JObject>();

                int i = 0;
                foreach (var item in resultObjects)
                {
                    var actions = item["actions"];
                    if (actions.ToString().Contains("battle_arena") && i==0)
                    {
                        Helper.SetText(this, this.LastAttackLBL, (string)item["blockIndex"].ToString());
                        i++;
                    }
                }
                if (i == 0)
                {
                   Helper.SetText(this, this.LastAttackLBL, "99999");
                }
                Thread.Sleep(3000);
            }
        }

        private async Task ArenaHelper_DiffCalc()
        {
            Thread.Sleep(10000);

            while (true)
            {
                int current = int.Parse(currentBlockLBL.Text);
                int lastfight = int.Parse(LastAttackLBL.Text);
                int difference = current - lastfight;

                switch (difference)
                {
                    case < 3:
                        Helper.SetText(this, this.DifferenceLBL, difference.ToString());
                        Helper.SetText(this, this.StatusLBL, "Wait");
                        this.StatusLBL.ForeColor = Color.Red;
                        break;

                    case 3:
                        Helper.SetText(this, this.DifferenceLBL, difference.ToString());
                        Helper.SetText(this, this.StatusLBL, "Risky");
                        this.StatusLBL.ForeColor = Color.LightSalmon;
                        break;

                    case > 3:
                        Helper.SetText(this, this.DifferenceLBL, difference.ToString());
                        Helper.SetText(this, this.StatusLBL, "Attack");
                        this.StatusLBL.ForeColor = Color.Green;
                        break;
                }
                Thread.Sleep(3000);
            }
        }

        private static IEnumerable<JToken> AllChildren(JToken json)
        {
            foreach (var c in json.Children())
            {
                yield return c;
                foreach (var cc in AllChildren(c))
                {
                    yield return cc;
                }
            }
        }

        private void CurrentBlock_DoWork_1(object sender, DoWorkEventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                ArenaHelper_GetCurrentBlock();
            }).Start();
        }

        private void LastAttack_DoWork(object sender, DoWorkEventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                ArenaHelper_GetLastAttack();
            }).Start();
        }

        private void differenceworker_DoWork(object sender, DoWorkEventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                /* run your code here */
                ArenaHelper_DiffCalc();
            }).Start();
        }
    }
}
