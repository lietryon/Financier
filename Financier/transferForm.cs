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
            Financier_dbEntities dbe = new Financier_dbEntities();
            decimal b = Convert.ToDecimal(fromacc.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            nametxt.Text = item.Name;
            currentbal.Text = Convert.ToString(item.Balance);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Financier_dbEntities dbe = new Financier_dbEntities();
            decimal b = Convert.ToDecimal(fromacc.Text);
            var item = (from u in dbe.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            decimal b1 = Convert.ToDecimal(item.Balance);
            decimal totalbal = Convert.ToDecimal(transferamount.Text);
            decimal transferacc = Convert.ToDecimal(destacc.Text);
            if (b1 > totalbal)
            {
                userAccount item2 = (from u in dbe.userAccounts
                                     where u.Account_No == transferacc
                                     select u).FirstOrDefault();
                item2.Balance = item2.Balance + totalbal;
                item.Balance = item.Balance - totalbal;

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
