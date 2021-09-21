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
    public partial class adminGiris : Form
    {
        string k_adi;
        string yetki;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Givinfo.mdb");
        public adminGiris(string k_ad)
        {
            InitializeComponent();
            k_adi = k_ad;
            baglanti.Open();
            OleDbCommand isimKomut = new OleDbCommand("Select adi from Kullanici_Kayit where kullanici_adi='" + k_ad + "'", baglanti);
            string isim = isimKomut.ExecuteScalar().ToString();
            OleDbCommand soyisimKomut = new OleDbCommand("Select soyadi from Kullanici_Kayit where kullanici_adi='" + k_ad + "'", baglanti);
            string soyisim = soyisimKomut.ExecuteScalar().ToString();
            label1.Text = "HOŞGELDİNİZ " + isim.ToUpper() + " " + soyisim.ToUpper() + ";";
            baglanti.Close();
        }

        private void adminGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void videoButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            videoForm video = new videoForm("admin");
            video.ShowDialog();
        }

        private void bilgiButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            bilgiForm bilgi = new bilgiForm("admin");
            bilgi.ShowDialog();
        }

        private void oyunButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            oyunForm oyun = new oyunForm(k_adi);
            oyun.ShowDialog();
        }

        private void kitapButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            kitapForm kitap = new kitapForm("admin");
            kitap.ShowDialog();
        }

        private void mesajButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mesajForm mesaj = new mesajForm(k_adi);
            mesaj.ShowDialog();
        }

        private void profilButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            kayitol profil = new kayitol(k_adi);
            profil.ShowDialog();
        }

        private void kullaniciButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            kullaniciForm kullanici = new kullaniciForm(k_adi);
            kullanici.ShowDialog();
        }
    }
}
