namespace ArenaHelper
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string address = textBox1.Text;
            ArenaHelper form = new ArenaHelper(address);
            form.Show();
            this.Hide();
        }
    }
}