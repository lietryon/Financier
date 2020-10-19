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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Financier_dbEntities dbe = new Financier_dbEntities();
            if (oldpass.Text != string.Empty || newpass.Text != string.Empty || repass.Text != string.Empty)
            {
                Admin_Table user1 = dbe.Admin_Table.FirstOrDefault(a => a.AccountNumber.Equals(usertxt.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(oldpass.Text))
                    {
                        user1.Password = newpass.Text;
                        dbe.SaveChanges();
                        MessageBox.Show("Password Change Successful");
                    }
                    else
                    {
                        MessageBox.Show("Password Incorrect");
                    }
                }
            }
        }
    }
}
