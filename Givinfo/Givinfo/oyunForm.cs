using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Givinfo
{
    public partial class oyunForm : Form
    {
        string k_ad;
        public oyunForm(string k_adi)
        {
            InitializeComponent();
            k_ad = k_adi;
        }
        private void oyunForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms["kullaniciGiris"] != null)
            {
                kullaniciGiris a = Application.OpenForms["kullaniciGiris"] as kullaniciGiris;
                a.Show();
            }
            else
            {
                adminGiris b = Application.OpenForms["adminGiris"] as adminGiris;
                b.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2(k_ad);
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            form.ShowDialog();
        }
    }
}
