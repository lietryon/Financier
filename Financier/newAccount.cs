using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financier
{
    public partial class newAccount : Form
    {

        string gender = string.Empty;
        string m_status = string.Empty;
        decimal no;
        Financier_dbEntities BSE;
        MemoryStream ms;

        public newAccount()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
            loadstate();
        }

        private void loadstate()
        {
            //throw new NotImplementedException();
            comboBox1.Items.Add("Czech Republic");
        }

        private void loadaccount()
        {
            BSE = new Financier_dbEntities();
            var item = BSE.userAccounts.ToArray();
            no = item.LastOrDefault().Account_No + 1;
            accnotext.Text = Convert.ToString(no); // Converts the Account Number to String
        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            datelbl.Text = DateTime.Now.ToString("MM//dd/yyyy");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if(maleradio.Checked)
            {
                gender = "male";
            }
            else if (femaleradio.Checked)
            {
                gender = "female";
            }
            else if (otherradio.Checked)
            {
                gender = "other";
            }
            if (marriedradio.Checked)
            {
                m_status = "married";
            }
            else if (singleradio.Checked)
            {
                m_status = "single";
            }

            BSE = new Financier_dbEntities();
            userAccount acc = new userAccount();
            acc.Account_No = Convert.ToDecimal(accnotext.Text);
            acc.Name = nametxt.Text;
            acc.DOB = dateTimePicker1.Value.ToString();
            acc.PhoneNo = phonetxt.Text;
            acc.Country = comboBox1.SelectedItem.ToString();
            acc.Gender = gender;
            acc.Maritial_Status = m_status;
            acc.Date = datelbl.Text;
            BSE.userAccounts.Add(acc);
            BSE.SaveChanges();
            MessageBox.Show("Account created");
        }
        
    }
}
