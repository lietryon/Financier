namespace Financier
{
    partial class withdrawForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.accnotxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.currentbal = new System.Windows.Forms.TextBox();
            this.withdrawamount = new System.Windows.Forms.TextBox();
            this.modeBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datelbl.Location = new System.Drawing.Point(51, 36);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(110, 20);
            this.datelbl.TabIndex = 2;
            this.datelbl.Text = "Current date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mode";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount";
            // 
            // accnotxt
            // 
            this.accnotxt.Location = new System.Drawing.Point(54, 174);
            this.accnotxt.Name = "accnotxt";
            this.accnotxt.Size = new System.Drawing.Size(134, 20);
            this.accnotxt.TabIndex = 6;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(54, 248);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(134, 20);
            this.nametxt.TabIndex = 7;
            // 
            // currentbal
            // 
            this.currentbal.Location = new System.Drawing.Point(54, 322);
            this.currentbal.Name = "currentbal";
            this.currentbal.Size = new System.Drawing.Size(134, 20);
            this.currentbal.TabIndex = 8;
            // 
            // withdrawamount
            // 
            this.withdrawamount.Location = new System.Drawing.Point(54, 489);
            this.withdrawamount.Name = "withdrawamount";
            this.withdrawamount.Size = new System.Drawing.Size(134, 20);
            this.withdrawamount.TabIndex = 9;
            // 
            // modeBox
            // 
            this.modeBox.FormattingEnabled = true;
            this.modeBox.Location = new System.Drawing.Point(54, 408);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(134, 21);
            this.modeBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Withdraw";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // withdrawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 623);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.modeBox);
            this.Controls.Add(this.withdrawamount);
            this.Controls.Add(this.currentbal);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.accnotxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "withdrawForm";
            this.Text = "withdrawForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox accnotxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox currentbal;
        private System.Windows.Forms.TextBox withdrawamount;
        private System.Windows.Forms.ComboBox modeBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}