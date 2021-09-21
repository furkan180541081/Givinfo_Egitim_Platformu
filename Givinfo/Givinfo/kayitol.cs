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
    public partial class kayitol : Form
    {
        string k_ad;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\Givinfo.mdb");
        public kayitol()
        {
            InitializeComponent();
            button1.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
        }
        public kayitol(string k_adi)
        {
            InitializeComponent();
            button1.Visible = false;
            button2.Visible = true;
            button3.Visible = true;
            txt_k_adi.Enabled = false; 
            k_ad = k_adi;
            OleDbCommand komut = new OleDbCommand("Select * from Kullanici_Kayit where kullanici_adi='" + k_ad + "'", baglanti);
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txt_ad.Text = dt.Rows[0]["adi"].ToString();
            txt_soyad.Text = dt.Rows[0]["soyadi"].ToString();
            txt_k_adi.Text = dt.Rows[0]["kullanici_adi"].ToString() + "  (Kullanıcı Adı Değiştirilemez!)";
            txt_eposta.Text = dt.Rows[0]["eposta_adresi"].ToString();
            txt_tel_no.Text = dt.Rows[0]["telefon_no"].ToString();
            txt_adres.Text = dt.Rows[0]["adres"].ToString();
            txt_sifre.Text = dt.Rows[0]["sifre"].ToString();
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text.Trim() != "" && txt_soyad.Text.Trim() != "" && txt_k_adi.Text.Trim() != "" && txt_eposta.Text.Trim() != "" && txt_tel_no.Text.Trim() != "" && txt_adres.Text.Trim() != "" && txt_sifre.Text.Trim() != "" && txt_sifre_tekrar.Text.Trim() != "" && txt_sifre.Text.Trim().Equals(txt_sifre_tekrar.Text.Trim()))
            {
                OleDbCommand mevcut_k_adi = new OleDbCommand("Select * from Kullanici_Kayit where kullanici_adi='" + txt_k_adi.Text.Trim().ToLower() + "'", baglanti);
                OleDbCommand mevcut_eposta = new OleDbCommand("Select * from Kullanici_Kayit where eposta_adresi='" + txt_eposta.Text.Trim().ToLower() + "'", baglanti);
                baglanti.Open();
                OleDbDataReader a = mevcut_k_adi.ExecuteReader();
                OleDbDataReader b = mevcut_eposta.ExecuteReader();
                if (a.Read() && b.Read())
                {
                    MessageBox.Show("Bu Kullanıcı Adı ve E-Posta Adresi Sistemde Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();
                }
                else if (a.Read())
                {
                    MessageBox.Show("Bu Kullanıcı Adı Sistemde Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();
                }
                else if (b.Read())
                {
                    MessageBox.Show("Bu E-Posta Adresi Sistemde Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();
                }

                else
                {
                    OleDbCommand kayit = new OleDbCommand("Insert into Kullanici_Kayit(adi,soyadi,kullanici_adi,eposta_adresi,telefon_no,adres,sifre,Yetki) values ('" + txt_ad.Text.Trim().ToLower() + "','" + txt_soyad.Text.Trim().ToLower() + "','" + txt_k_adi.Text.Trim().ToLower() + "','" + txt_eposta.Text.Trim().ToLower() + "','" + txt_tel_no.Text.Trim() + "','" + txt_adres.Text.Trim().ToLower() + "','" + txt_sifre.Text.Trim() + "','" + "kullanıcı" + "')", baglanti);
                    kayit.ExecuteNonQuery();
                    kayit.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Tamamlandı!", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız ve Şifreleri Birbirine Uyumlu Giriniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }     
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Kaydınızı Silmek İstediğinizden Emin Misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                OleDbCommand sil = new OleDbCommand("Delete * from Kullanici_Kayit where kullanici_adi='" + k_ad + "'", baglanti);
                baglanti.Open();
                sil.ExecuteNonQuery();
                sil.Dispose();
                baglanti.Close();
                MessageBox.Show("Kaydınız Başarıyla Silinmiştir...", "Kayıt Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_ad.Text.Trim() != "" && txt_soyad.Text.Trim() != "" && txt_tel_no.Text.Trim() != "" && txt_adres.Text.Trim() != "" && txt_sifre.Text.Trim() != "" && txt_sifre_tekrar.Text.Trim() != "" && txt_sifre.Text.Trim().Equals(txt_sifre_tekrar.Text.Trim()))
            {
                OleDbCommand guncelle = new OleDbCommand("Update Kullanici_Kayit set adi='" + txt_ad.Text.Trim().ToLower() + "',soyadi='" + txt_soyad.Text.Trim().ToLower() + "',telefon_no='" + txt_tel_no.Text.Trim() + "',adres='" + txt_adres.Text.Trim().ToLower() + "',sifre='" + txt_sifre.Text.Trim() + "'where kullanici_adi='" + k_ad + "'", baglanti);
                baglanti.Open();
                guncelle.ExecuteNonQuery();
                guncelle.Dispose();
                baglanti.Close();
                MessageBox.Show("Kayıt Güncellendi!", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız ve Şifreleri Birbirine Uyumlu Giriniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }     
        }
        private void kayitol_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms["kullaniciGiris"] != null)
            {
                kullaniciGiris a = Application.OpenForms["kullaniciGiris"] as kullaniciGiris;
                a.Show();
            }
            else if (Application.OpenForms["adminGiris"] != null)
            {
                adminGiris b = Application.OpenForms["adminGiris"] as adminGiris;
                b.Show();
            }
            else
            {
                giris giris1 = new giris();
                giris1.Visible = true;
            }
        }
    }
}
