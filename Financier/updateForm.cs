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
    public partial class updateForm : Form
    {

        Financier_dbEntities dbe;
        MemoryStream ms;
        BindingList<userAccount> bi;
        public updateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bi = new BindingList<userAccount>();
            dbe = new Financier_dbEntities();
            decimal accno = Convert.ToDecimal(acctxt.Text);
            var item = dbe.userAccounts.Where(a => a.Account_No == accno);
            foreach (var item1 in item)
            {
                bi.Add(item1);
            }
            dataGridView1.DataSource = bi;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dbe = new Financier_dbEntities();
            decimal accno = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            var item = dbe.userAccounts.Where(a => a.Account_No == accno).FirstOrDefault();
            acctxt.Text = item.Account_No.ToString();
            nametxt.Text = item.Name;
            phonetxt.Text = item.PhoneNo;
            byte[] img = item.Picture;
            countrytxt.Text = item.Country;
            if (img != null)
            {
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            if (item.Gender == "male")
            {
                maleradio.Checked = true;
            }
            else if (item.Gender == "female")
            {
                femaleradio.Checked = true;
            }
            else if (item.Gender == "other")
            {
                otherradio.Checked = true;
            }
            if (item.Maritial_Status == "married")
            {
                marriedradio.Checked = true;
            }
            else if (item.Maritial_Status == "single")
            {
                singleradio.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendlg = new OpenFileDialog();

            if (opendlg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opendlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bi.RemoveAt(dataGridView1.SelectedRows[0].Index);
            dbe = new Financier_dbEntities();
            decimal a = Convert.ToDecimal(acctxt.Text);
            userAccount acc = dbe.userAccounts.First(s => s.Account_No.Equals(a));
            dbe.userAccounts.Remove(acc);
            dbe.SaveChanges();
        }
    }
}
