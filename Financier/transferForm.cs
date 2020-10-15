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
    public partial class transferForm : Form
    {
        public transferForm()
        {
            InitializeComponent();
            loaddate();
        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            datelbl.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            retrievedata();
        }

        private void retrievedata()
        {
            // Retrieve data from the database
            Financier_dbEntities dbe = new Financier_dbEntities();
            decimal b = Convert.ToDecimal(fromacc.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            nametxt.Text = item.Name; // Search for name
            currentbal.Text = Convert.ToString(item.Balance); // Search for current balance
        }

        private void button1_Click(object sender, EventArgs e)
        {
            savedata();
        }

        private void savedata()
        {
            Financier_dbEntities dbe = new Financier_dbEntities();
            // Search through database
            decimal b = Convert.ToDecimal(fromacc.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            // Change values in database based on new input values
            decimal b1 = Convert.ToDecimal(item.Balance);
            decimal totalbal = Convert.ToDecimal(transferamount.Text);
            decimal transferacc = Convert.ToDecimal(destacc.Text);
            // Condition for withdrawal
            // TODO: Fix the condition - can't transfer when balance is the same transfer amount
            if (b1 > totalbal)
            {
                userAccount item2 = (from u in dbe.userAccounts
                                     where u.Account_No == transferacc
                                     select u).FirstOrDefault();
                item2.Balance = item2.Balance + totalbal; // Add the amount to destination account
                item.Balance = item.Balance - totalbal; // Deduct the amount from sender's account

                transfer transfer = new transfer();
                transfer.Account_No = Convert.ToDecimal(fromacc.Text);
                transfer.ToTransfer = Convert.ToDecimal(destacc.Text);
                transfer.Date = DateTime.UtcNow.ToString();
                transfer.Name = nametxt.Text;
                transfer.Balance = Convert.ToDecimal(transferamount.Text);

                dbe.transfers.Add(transfer);
                dbe.SaveChanges();
                MessageBox.Show("Transfer Successful");
            }
        }
    }
}
