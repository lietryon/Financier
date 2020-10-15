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
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void accNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Financier_dbEntities dbe = new Financier_dbEntities();
            if (accNumber.Text != string.Empty || password.Text != string.Empty)
            {
                var user1 = dbe.Admin_Table.FirstOrDefault(a => a.AccountNumber.Equals(accNumber.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(password.Text))
                    {
                        Menu m1 = new Menu();
                        m1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect values");
                }
            }
            else
            {
                MessageBox.Show("Please, enter your Account Number and Password");
            }
        }
    }
}
