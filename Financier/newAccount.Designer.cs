namespace Financier
{
    partial class newAccount
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
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.femaleradio = new System.Windows.Forms.RadioButton();
            this.maleradio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.marriedradio = new System.Windows.Forms.RadioButton();
            this.singleradio = new System.Windows.Forms.RadioButton();
            this.otherradio = new System.Windows.Forms.RadioButton();
            this.accnotext = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(292, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Account Creation";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Location = new System.Drawing.Point(431, 55);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(52, 13);
            this.datelbl.TabIndex = 2;
            this.datelbl.Text = "Datelabel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Account Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Country";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.femaleradio);
            this.groupBox1.Controls.Add(this.maleradio);
            this.groupBox1.Location = new System.Drawing.Point(470, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // femaleradio
            // 
            this.femaleradio.AutoSize = true;
            this.femaleradio.Location = new System.Drawing.Point(102, 33);
            this.femaleradio.Name = "femaleradio";
            this.femaleradio.Size = new System.Drawing.Size(59, 17);
            this.femaleradio.TabIndex = 1;
            this.femaleradio.TabStop = true;
            this.femaleradio.Text = "Female";
            this.femaleradio.UseVisualStyleBackColor = true;
            // 
            // maleradio
            // 
            this.maleradio.AutoSize = true;
            this.maleradio.Location = new System.Drawing.Point(6, 33);
            this.maleradio.Name = "maleradio";
            this.maleradio.Size = new System.Drawing.Size(48, 17);
            this.maleradio.TabIndex = 0;
            this.maleradio.TabStop = true;
            this.maleradio.Text = "Male";
            this.maleradio.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.marriedradio);
            this.groupBox2.Controls.Add(this.singleradio);
            this.groupBox2.Location = new System.Drawing.Point(470, 246);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 77);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Maritial Status";
            // 
            // marriedradio
            // 
            this.marriedradio.AutoSize = true;
            this.marriedradio.Location = new System.Drawing.Point(166, 31);
            this.marriedradio.Name = "marriedradio";
            this.marriedradio.Size = new System.Drawing.Size(60, 17);
            this.marriedradio.TabIndex = 1;
            this.marriedradio.TabStop = true;
            this.marriedradio.Text = "Married";
            this.marriedradio.UseVisualStyleBackColor = true;
            // 
            // singleradio
            // 
            this.singleradio.AutoSize = true;
            this.singleradio.Location = new System.Drawing.Point(68, 31);
            this.singleradio.Name = "singleradio";
            this.singleradio.Size = new System.Drawing.Size(54, 17);
            this.singleradio.TabIndex = 0;
            this.singleradio.TabStop = true;
            this.singleradio.Text = "Single";
            this.singleradio.UseVisualStyleBackColor = true;
            // 
            // otherradio
            // 
            this.otherradio.AutoSize = true;
            this.otherradio.Location = new System.Drawing.Point(679, 165);
            this.otherradio.Name = "otherradio";
            this.otherradio.Size = new System.Drawing.Size(51, 17);
            this.otherradio.TabIndex = 2;
            this.otherradio.TabStop = true;
            this.otherradio.Text = "Other";
            this.otherradio.UseVisualStyleBackColor = true;
            // 
            // accnotext
            // 
            this.accnotext.Location = new System.Drawing.Point(58, 148);
            this.accnotext.Name = "accnotext";
            this.accnotext.Size = new System.Drawing.Size(147, 20);
            this.accnotext.TabIndex = 9;
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(58, 208);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(147, 20);
            this.nametxt.TabIndex = 10;
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(58, 343);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(147, 20);
            this.phonetxt.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Date of Birth";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 277);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 397);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(58, 462);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(147, 34);
            this.savebutton.TabIndex = 16;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // newAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 539);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.accnotext);
            this.Controls.Add(this.otherradio);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "newAccount";
            this.Text = "newAccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton femaleradio;
        private System.Windows.Forms.RadioButton maleradio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton marriedradio;
        private System.Windows.Forms.RadioButton singleradio;
        private System.Windows.Forms.RadioButton otherradio;
        private System.Windows.Forms.TextBox accnotext;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button savebutton;
    }
}