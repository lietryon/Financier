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
    public partial class balanceSheet : Form
    {
        public balanceSheet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Financier_dbEntities dbe = new Financier_dbEntities();
            decimal b = Convert.ToDecimal(textBox1.Text);
            var item = (from u in dbe.debits
                        where u.Account_No == b
                        select u);
            dataGridView1.DataSource = item.ToList();
            var item1 = (from u in dbe.deposits
                         where u.Account_No == b
                         select u);
            dataGridView2.DataSource = item1.ToList();
            var item2 = (from u in dbe.transfers
                         where u.Account_No == b
                         select u);
            dataGridView3.DataSource = item2.ToList();
        }
    }
}
