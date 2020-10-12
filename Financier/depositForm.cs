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
    public partial class depositForm : Form
    {
        public depositForm()
        {
            InitializeComponent();
            loaddate();
            loadmode();
        }

        private void loadmode()
        {
            //throw new NotImplementedException();
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Cheque");
        }

        private void loaddate()
        {
            //throw new NotImplementedException();
            datelbl.Text = DateTime.UtcNow.ToString("MM/dd/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Financier_dbEntities context = new Financier_dbEntities();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            nametxt.Text = item.Name;
            oldbaltxt.Text = Convert.ToString(item.Balance);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Financier_dbEntities context = new Financier_dbEntities();
            newAccount acc = new newAccount();
            deposit dp = new deposit();
            dp.Date = datelbl.Text;
            dp.Account_No = Convert.ToDecimal(acctxt.Text);
            dp.Name = nametxt.Text;
            dp.OldBalance = Convert.ToDecimal(oldbaltxt.Text);
            dp.Mode = comboBox1.SelectedItem.ToString();
            dp.DepositAmount = Convert.ToDecimal(amounttxt.Text);
            context.deposits.Add(dp);
            context.SaveChanges();
            decimal b = Convert.ToDecimal(acctxt.Text);
            var item = (from u in context.userAccounts
                        where u.Account_No == b
                        select u).FirstOrDefault();
            item.Balance = item.Balance + Convert.ToDecimal(amounttxt.Text);
            context.SaveChanges();
            MessageBox.Show("Deposit Successful");
        }
    }
}
