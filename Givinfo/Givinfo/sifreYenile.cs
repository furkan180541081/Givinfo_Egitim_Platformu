using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.OleDb;

namespace Givinfo
{
    public partial class sifreYenile : Form
    {
        public sifreYenile()
        {
            InitializeComponent();
        }
        string dogrulamaKodu = "";
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Givinfo.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand mevcut_eposta = new OleDbCommand("Select * from Kullanici_Kayit where eposta_adresi='" + textBox1.Text.Trim() + "'", baglanti);
            baglanti.Open();
            OleDbDataReader a = mevcut_eposta.ExecuteReader();
            if (a.Read())
            {
                Random rastgele = new Random();
                string elemanlar = "ABCDEFGHIJKLMNOPRSTUVYZWX1234567890";
                for (int i = 0; i < 6; i++) { dogrulamaKodu += elemanlar[rastgele.Next(elemanlar.Length)]; }
                MailMessage mesaj = new MailMessage("e_eczacim.180541081@outlook.com", textBox1.Text, "Givinfo Eğitim Platformu Onay Kodu", "Üyeliğinizin onaylanması için geçerli onay kodunuz: '" + dogrulamaKodu + "'\n\nGivinfo Eğitim Platformu Sistemi");
                SmtpClient istemci = new SmtpClient("smtp.live.com", 587);
                istemci.EnableSsl = true;
                istemci.UseDefaultCredentials = true;
                istemci.Credentials = new System.Net.NetworkCredential("e_eczacim.180541081@outlook.com", "180541081.Furkan");
                istemci.Send(mesaj);
                MessageBox.Show("Doğrulama Kodunuz Başarıyla Gönderilmiştir. Lütfen Doğrulama Kodunu Alttaki Kutucuğa Girip, Doğrula Butonuna Basınız...", "Doğrulama Kodu Gönderimi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
                panel2.Visible = true;
            }
            else
            {
                MessageBox.Show("Bu E-Posta Adresi Sistemde Kayıtlı Değil!", "E-Posta Adresi Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Equals(dogrulamaKodu))
            {
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Gönderilen Doğrulama Kodu, Girilen Kodla Uyumlu Değil! Lütfen Tekrar Deneyin...", "Doğrulama Kodu Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.Trim() != "" && textBox8.Text.Trim() != "" && textBox7.Text.Trim().Equals(textBox7.Text.Trim()))
            {
                baglanti.Open();
                OleDbCommand sifre_guncelle = new OleDbCommand("Update Kullanici_Kayit set sifre='" + textBox7.Text.Trim() + "'where eposta_adresi='" + textBox1.Text.Trim() + "'", baglanti);
                sifre_guncelle.ExecuteNonQuery();
                sifre_guncelle.Dispose();
                baglanti.Close();
                MessageBox.Show("Şifre Güncellendi!", "Şifre Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Girilen Şifreler Birbirine Uyumlu Değil! Lütfen Tekrar Deneyin...", "Şifre Uyumu Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void sifreyenile_FormClosing(object sender, FormClosingEventArgs e)
        {
            giris giris1 = new giris();
            giris1.Visible = true;
        }
    }
}
