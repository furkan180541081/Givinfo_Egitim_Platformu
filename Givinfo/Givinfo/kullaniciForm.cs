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
    public partial class kullaniciForm : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Givinfo.mdb");
        string kullanici_adi;
        public kullaniciForm(string k_ad)
        {
            InitializeComponent();
            kullanici_adi = k_ad;
            Kullanici_Listele();
        }
        public void Kullanici_Listele()
        {
            OleDbCommand komut = new OleDbCommand("Select * from Kullanici_Kayit", baglanti);
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }
        private void btn_kullaniciSil_Click(object sender, EventArgs e)
        {
            string kul_adi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            OleDbCommand yetkiKomut = new OleDbCommand("Select Yetki from Kullanici_Kayit where kullanici_adi='" + kul_adi + "'", baglanti);
            baglanti.Open();
            string yetki = yetkiKomut.ExecuteScalar().ToString();
            baglanti.Close();
            if (yetki.Equals("kullanıcı"))
            {
                OleDbCommand komut1 = new OleDbCommand("Delete * from Kullanici_Kayit where kullanici_adi='" + kul_adi + "'", baglanti);
                OleDbCommand komut2 = new OleDbCommand("Delete * from mesajlar where gonderici='" + kul_adi + "'", baglanti);
                OleDbCommand komut3 = new OleDbCommand("Delete * from mesajlar where alici='" + kul_adi + "'", baglanti);
                baglanti.Open();
                komut1.ExecuteNonQuery();
                komut2.ExecuteNonQuery();
                komut3.ExecuteNonQuery();
                komut1.Dispose();
                komut2.Dispose();
                komut3.Dispose();
                baglanti.Close();
                Kullanici_Listele();
            }
            else
            {
                MessageBox.Show("Yetki Seviyesi Admin Olan Yöneticileri Silemezsiniz...", "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_kullaniciYetki_Click(object sender, EventArgs e)
        {
            string kul_adi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            OleDbCommand komut = new OleDbCommand("Update Kullanici_Kayit set Yetki='" + "admin" + "' where kullanici_adi='" + kul_adi + "'", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglanti.Close();
            Kullanici_Listele();
        }
        private void btn_yetkiDusur_Click(object sender, EventArgs e)
        {
            string kul_adi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (kul_adi.Equals("despra") || kullanici_adi==kul_adi)
            {
                MessageBox.Show("Yetki Seviyesi Birincil Admin Olan Yöneticinin ve Kendinizin Yetkisini Düşüremezsiniz...", "Yetki Düşürme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbCommand komut = new OleDbCommand("Update Kullanici_Kayit set Yetki='" + "kullanıcı" + "' where kullanici_adi='" + kul_adi + "'", baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                Kullanici_Listele();
            }
        }
        private void kullaniciForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            adminGiris a = Application.OpenForms["adminGiris"] as adminGiris;
            a.Show();
        }
    }
}
