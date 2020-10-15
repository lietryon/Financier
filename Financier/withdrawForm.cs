using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Financier
{
    public partial class withdrawForm : Form
    {
        public withdrawForm()
        {
            InitializeComponent();
            loadcombo();
            loaddate();
        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            datelbl.Text = DateTime.UtcNow.ToString("MM//dd//yyyy");
        }

        private void loadcombo()
        {
            //throw new NotImplementedException();
            modeBox.Items.Add("Cash");
            modeBox.Items.Add("Cheque");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            retrievedata();
        }

        private void savedata()
        {
            // Save the new data
            Financier_dbEntities dbe = new Financier_dbEntities();
            newAccount newacc = new newAccount();
            debit dp = new debit();
            dp.Date = datelbl.Text;
            dp.Account_No = Convert.ToDecimal(accnotxt.Text);
            dp.Name = nametxt.Text;
            dp.OldBalance = Convert.ToDecimal(currentbal.Text);
            dp.Mode = modeBox.SelectedItem.ToString();
            dp.DebAmount = Convert.ToDecimal(withdrawamount.Text);
            dbe.debits.Add(dp);
            dbe.SaveChanges();
            decimal b = Convert.ToDecimal(accnotxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            item.Balance = item.Balance - Convert.ToDecimal(withdrawamount.Text);
            dbe.SaveChanges();
            MessageBox.Show("Withdrawal Successful");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            savedata();
        }

        private void retrievedata()
        {
            // After clicking on Search button - retrieve data from database
            Financier_dbEntities dbe = new Financier_dbEntities();
            decimal b = Convert.ToDecimal(accnotxt.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            nametxt.Text = item.Name; // Search for name
            currentbal.Text = Convert.ToString(item.Balance); // Search for current balance
        }
    }
}
