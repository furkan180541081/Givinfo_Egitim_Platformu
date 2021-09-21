using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Givinfo
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Givinfo.mdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from Kullanici_Kayit where kullanici_adi='" + textBox1.Text + "' and sifre = '" + textBox2.Text + "'", baglanti);
            OleDbDataReader okuma = komut.ExecuteReader();
            if (okuma.Read())
            {
                this.Hide();
                OleDbCommand yetkiKomut = new OleDbCommand("Select Yetki from Kullanici_Kayit where kullanici_adi='" + textBox1.Text + "'", baglanti);
                string Yetkisi = yetkiKomut.ExecuteScalar().ToString();
                if (Yetkisi == "admin")
                {
                    adminGiris yetkili = new adminGiris(textBox1.Text);
                    yetkili.ShowDialog();
                }
                else
                {
                    kullaniciGiris kullanici = new kullaniciGiris(textBox1.Text);
                    kullanici.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız ve Şifreniz Hatalı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "Kullanıcı Adınızı Girin..."; textBox1.ForeColor = Color.Gray;
                textBox2.Text = "Şifrenizi Girin..."; textBox2.ForeColor = Color.Gray; textBox2.PasswordChar = '\0';
                textBox1.Select();
            }
            baglanti.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            sifreYenile sifre = new sifreYenile();
            sifre.ShowDialog();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kullanıcı Adınızı Girin...")
            {
                textBox1.Text = null;
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.ForeColor = Color.Gray;
                textBox1.Text = "Kullanıcı Adınızı Girin...";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Şifrenizi Girin...")
            {
                textBox2.Text = null;
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            } 
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.ForeColor = Color.Gray;
                textBox2.PasswordChar = '\0';
                textBox2.Text = "Şifrenizi Girin...";
            }
        }


        private void sifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "Şifrenizi Girin...")
            {
                if (sifreyiGoster.Checked)
                {
                    textBox2.PasswordChar = '\0';
                }
                else
                {
                    textBox2.PasswordChar = '*';
                }
            }
        }

        private void giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kayitbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayitol kayit1 = new kayitol();
            kayit1.ShowDialog();
        }
    }
}
