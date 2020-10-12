namespace Financier
{
    partial class transferForm
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
            this.datelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fromacc = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.currentbal = new System.Windows.Forms.TextBox();
            this.destacc = new System.Windows.Forms.TextBox();
            this.transferamount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datelbl.Location = new System.Drawing.Point(58, 42);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(113, 20);
            this.datelbl.TabIndex = 0;
            this.datelbl.Text = "Current Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sender\'s Account Number\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Current Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Receiver\'s Account Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount";
            // 
            // fromacc
            // 
            this.fromacc.Location = new System.Drawing.Point(62, 130);
            this.fromacc.Name = "fromacc";
            this.fromacc.Size = new System.Drawing.Size(137, 20);
            this.fromacc.TabIndex = 6;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(62, 200);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(137, 20);
            this.nametxt.TabIndex = 7;
            // 
            // currentbal
            // 
            this.currentbal.Location = new System.Drawing.Point(62, 266);
            this.currentbal.Name = "currentbal";
            this.currentbal.Size = new System.Drawing.Size(137, 20);
            this.currentbal.TabIndex = 8;
            // 
            // destacc
            // 
            this.destacc.Location = new System.Drawing.Point(62, 335);
            this.destacc.Name = "destacc";
            this.destacc.Size = new System.Drawing.Size(137, 20);
            this.destacc.TabIndex = 9;
            // 
            // transferamount
            // 
            this.transferamount.Location = new System.Drawing.Point(62, 404);
            this.transferamount.Name = "transferamount";
            this.transferamount.Size = new System.Drawing.Size(137, 20);
            this.transferamount.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Transfer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(259, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // transferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 657);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.transferamount);
            this.Controls.Add(this.destacc);
            this.Controls.Add(this.currentbal);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.fromacc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datelbl);
            this.Name = "transferForm";
            this.Text = "transferForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fromacc;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox currentbal;
        private System.Windows.Forms.TextBox destacc;
        private System.Windows.Forms.TextBox transferamount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}