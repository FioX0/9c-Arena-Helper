namespace ArenaHelper
{
    partial class ArenaHelper
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.currentBlockLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LastAttackLBL = new System.Windows.Forms.Label();
            this.StatusLBL = new System.Windows.Forms.Label();
            this.CurrentBlock = new System.ComponentModel.BackgroundWorker();
            this.LastAttack = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.DifferenceLBL = new System.Windows.Forms.Label();
            this.differenceworker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Block:";
            // 
            // currentBlockLBL
            // 
            this.currentBlockLBL.AutoSize = true;
            this.currentBlockLBL.Location = new System.Drawing.Point(120, 4);
            this.currentBlockLBL.Name = "currentBlockLBL";
            this.currentBlockLBL.Size = new System.Drawing.Size(13, 15);
            this.currentBlockLBL.TabIndex = 1;
            this.currentBlockLBL.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Fight Block:";
            // 
            // LastAttackLBL
            // 
            this.LastAttackLBL.AutoSize = true;
            this.LastAttackLBL.Location = new System.Drawing.Point(120, 31);
            this.LastAttackLBL.Name = "LastAttackLBL";
            this.LastAttackLBL.Size = new System.Drawing.Size(13, 15);
            this.LastAttackLBL.TabIndex = 3;
            this.LastAttackLBL.Text = "0";
            // 
            // StatusLBL
            // 
            this.StatusLBL.AutoSize = true;
            this.StatusLBL.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLBL.ForeColor = System.Drawing.Color.Green;
            this.StatusLBL.Location = new System.Drawing.Point(56, 70);
            this.StatusLBL.Name = "StatusLBL";
            this.StatusLBL.Size = new System.Drawing.Size(114, 37);
            this.StatusLBL.TabIndex = 4;
            this.StatusLBL.Text = "Loading";
            this.StatusLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentBlock
            // 
            this.CurrentBlock.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CurrentBlock_DoWork_1);
            // 
            // LastAttack
            // 
            this.LastAttack.DoWork += new System.ComponentModel.DoWorkEventHandler(this.LastAttack_DoWork);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Difference:";
            // 
            // DifferenceLBL
            // 
            this.DifferenceLBL.AutoSize = true;
            this.DifferenceLBL.Location = new System.Drawing.Point(120, 55);
            this.DifferenceLBL.Name = "DifferenceLBL";
            this.DifferenceLBL.Size = new System.Drawing.Size(50, 15);
            this.DifferenceLBL.TabIndex = 6;
            this.DifferenceLBL.Text = "Loading";
            // 
            // differenceworker
            // 
            this.differenceworker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.differenceworker_DoWork);
            // 
            // ArenaHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 115);
            this.Controls.Add(this.DifferenceLBL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StatusLBL);
            this.Controls.Add(this.LastAttackLBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentBlockLBL);
            this.Controls.Add(this.label1);
            this.Name = "ArenaHelper";
            this.Text = "Arena Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label currentBlockLBL;
        private Label label3;
        private Label LastAttackLBL;
        private Label StatusLBL;
        private System.ComponentModel.BackgroundWorker CurrentBlock;
        private System.ComponentModel.BackgroundWorker LastAttack;
        private Label label2;
        private Label DifferenceLBL;
        private System.ComponentModel.BackgroundWorker differenceworker;
    }
}