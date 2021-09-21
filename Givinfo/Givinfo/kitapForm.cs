using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Givinfo
{
    public partial class kitapForm : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\Givinfo.mdb");
        public kitapForm(string k_ad)
        {
            InitializeComponent();
            if (k_ad == "admin")
            {
                button1.Visible = true;
                button2.Visible = true;
                listBox1.Height = 468;
            }
            listBox1.Items.Clear();
            string[] dosyalar = Directory.GetFiles(Application.StartupPath + "/Kitaplar");
            foreach (string kitap in dosyalar)
            {
                if (kitap.EndsWith(".pdf"))
                    listBox1.Items.Add(Path.GetFileName(kitap).Remove(Path.GetFileName(kitap).Length - 4, 4));
            }
        }

        private void kitapForm_FormClosing(object sender, FormClosingEventArgs e)
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
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.Filter = "PDF Dosyaları |*.pdf";
            dosya.ShowDialog();
            if(dosya.FileName!="")
            {
                axAcroPDF1.LoadFile(dosya.FileName);
                int indeks=listBox1.Items.Count;
                string kayitYeri = Application.StartupPath + "/Kitaplar/" + Path.GetFileName(dosya.FileName);
                File.Copy(dosya.FileName, kayitYeri);
                MessageBox.Show("Kitap Eklenmiştir...", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listBox1.Items.Add(Path.GetFileName(kayitYeri).Remove(Path.GetFileName(kayitYeri).Length - 4, 4));
                listBox1.SelectedIndex = indeks;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                listBox1.SelectedIndex = 0;
            }
            string isim = listBox1.SelectedItem.ToString();
            axAcroPDF1.LoadFile(Application.StartupPath + "/Kitaplar/" + isim + ".pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string isim = listBox1.SelectedItem.ToString();
            File.Delete(Application.StartupPath + "/Kitaplar/" + isim + ".pdf");
            MessageBox.Show("Kitap Silinmiştir...","Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listBox1.Items.Remove(isim);
        }
    }
}
