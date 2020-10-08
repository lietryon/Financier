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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newAccount newacc = new newAccount();
            newacc.MdiParent = this;
            newacc.Show();
        }

        private void updateSearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateForm upform = new updateForm();
            upform.MdiParent = this;
            upform.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            depositForm deposit = new depositForm();
            deposit.MdiParent = this;
            deposit.Show();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withdrawForm withdraw = new withdrawForm();
            withdraw.MdiParent = this;
            withdraw.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            transferForm transfer = new transferForm();
            transfer.MdiParent = this;
            transfer.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            balanceSheet balSheet = new balanceSheet();
            balSheet.MdiParent = this;
            balSheet.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePassword = new ChangePasswordForm();
            changePassword.MdiParent = this;
            changePassword.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
