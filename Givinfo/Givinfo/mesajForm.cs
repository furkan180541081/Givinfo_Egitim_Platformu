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
    public partial class mesajForm : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Givinfo.mdb");
        string kullanici_adi;
        public mesajForm(string k_ad)
        {
            InitializeComponent();
            kullanici_adi = k_ad;
            dgv_gelen_kutusu.Columns.Add("sutun_satici", "Satıcı");
            dgv_gelen_kutusu.Columns.Add("sutun_mesaj", "Mesaj");
            dgv_gelen_kutusu.Columns.Add("sutun_gondermeTarihi", "Gönderme Tarihi");
            gelen_veri_cek();
            dgv_giden_kutusu.Columns.Add("sutun_alici", "Alıcı Kişi");
            dgv_giden_kutusu.Columns.Add("sutun_mesaj", "Mesaj");
            dgv_giden_kutusu.Columns.Add("sutun_gondermeTarihi", "Gönderme Tarihi");
            giden_veri_cek();
            kullanici_veri_cek();
        }
        public void gelen_veri_cek()
        {
            dgv_gelen_kutusu.Rows.Clear();
            OleDbCommand gelen_komut = new OleDbCommand("Select * from mesajlar where alici='" + kullanici_adi + "'", baglanti);
            baglanti.Open();
            OleDbDataReader gelen_oku = gelen_komut.ExecuteReader();
            if (gelen_oku.HasRows)
            {
                while (gelen_oku.Read())
                {
                    dgv_gelen_kutusu.Rows.Add(gelen_oku["gonderici"].ToString(), gelen_oku["mesaj"].ToString(), gelen_oku["gonderme_tarihi"].ToString());
                }
                label3.Visible = false;
            }
            else
            {
                label3.Visible = true;
            }

            baglanti.Close();
        }
        public void kullanici_veri_cek()
        {
            kullanicilar.Refresh();
            OleDbCommand kullanici_komut = new OleDbCommand("Select * from Kullanici_Kayit", baglanti);
            baglanti.Open();
            OleDbDataReader kullanici_oku = kullanici_komut.ExecuteReader();
            if (kullanici_oku.HasRows)
            {
                while (kullanici_oku.Read())
                {
                    if (kullanici_oku["kullanici_adi"].ToString() != kullanici_adi)
                    {
                        kullanicilar.Items.Add(kullanici_oku["kullanici_adi"].ToString());
                    }
                }
            }
            baglanti.Close();
        }
        public void giden_veri_cek()
        {
            dgv_giden_kutusu.Rows.Clear();
            OleDbCommand giden_komut = new OleDbCommand("Select * from mesajlar where gonderici='" + kullanici_adi + "'", baglanti);
            baglanti.Open();
            OleDbDataReader giden_oku = giden_komut.ExecuteReader();
            if (giden_oku.HasRows)
            {
                while (giden_oku.Read())
                {
                    dgv_giden_kutusu.Rows.Add(giden_oku["alici"].ToString(), giden_oku["mesaj"].ToString(), giden_oku["gonderme_tarihi"].ToString());
                }
                label4.Visible = false;
            }
            else
            {
                label4.Visible = true;
            }

            baglanti.Close();
        }
        private void mesajForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dgv_giden_kutusu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_giden_mesaj.Text = dgv_giden_kutusu.CurrentRow.Cells[1].Value.ToString();
            txt_giden_mesaj.Enabled = false;
            txt_giden_mesaj.ReadOnly = true;
            button4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_gelen_kutusu.CurrentRow.Cells[0].Value.ToString() != "")
            {
                textBox1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                baglanti.Open();
                string alici = dgv_gelen_kutusu.CurrentRow.Cells[0].Value.ToString();
                OleDbCommand komut = new OleDbCommand("Insert into mesajlar(gonderici,alici,mesaj,gonderme_tarihi) values ('" + kullanici_adi + "','" + alici + "','" + textBox1.Text.Trim() + "','" + DateTime.Now.ToString() + "')", baglanti);
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Mesajınız Gönderilmiştir...", "İletildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                giden_veri_cek();
                textBox1.Visible = false;
                button3.Visible = false;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Mesajı Silmek İstediğinizden Emin Misiniz?", "Mesaj Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                OleDbCommand sil = new OleDbCommand("Delete * from mesajlar where mesaj='" + dgv_giden_kutusu.CurrentRow.Cells[1].Value.ToString() + "'", baglanti);
                baglanti.Open();
                sil.ExecuteNonQuery();
                sil.Dispose();
                baglanti.Close();
                MessageBox.Show("Mesaj Başarıyla Silinmiştir...", "Mesaj Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                giden_veri_cek();
            }
        }
        private void dgv_gelen_kutusu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label1.Visible = false;
            txt_gelen_mesaj.Visible = true;
            button1.Visible = true;
            txt_gelen_mesaj.Text = dgv_gelen_kutusu.CurrentRow.Cells[1].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txt_gelen_mesaj.Visible = false;
            button1.Visible = false;
            label1.Visible = true;
        }

        private void kullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_giden_mesaj.ReadOnly = false;
            txt_giden_mesaj.Enabled = true;
            txt_giden_mesaj.Text = "GÖNDERECEĞİNİZ MESAJI BURAYA GİRİNİZ...";
            txt_giden_mesaj.ForeColor = Color.Gray;
        }
        private void txt_giden_mesaj_Enter(object sender, EventArgs e)
        {
            txt_giden_mesaj.Clear();
            txt_giden_mesaj.ForeColor = Color.Black;
            button4.Visible = true;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_giden_mesaj.Text.Trim() != "GÖNDERECEĞİNİZ MESAJI BURAYA GİRİNİZ..." & txt_giden_mesaj.Text.Trim() != "")
            {
                baglanti.Open();
                string alici = kullanicilar.SelectedItem.ToString();
                OleDbCommand komut = new OleDbCommand("Insert into mesajlar(gonderici,alici,mesaj,gonderme_tarihi) values ('" + kullanici_adi + "','" + alici + "','" + txt_giden_mesaj.Text.Trim() + "','" + DateTime.Now.ToString() + "')", baglanti);
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("Mesajınız Gönderilmiştir...", "İletildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                giden_veri_cek();
                txt_giden_mesaj.Clear();
                kullanicilar.SelectedIndex = -1;
                txt_giden_mesaj.ReadOnly = true;
                txt_giden_mesaj.Enabled = false;
                txt_giden_mesaj.Text="GÖNDERECEĞİNİZ MESAJI BURAYA GİRİNİZ...";
                txt_giden_mesaj.ForeColor = Color.Gray;
                button4.Visible = false;
            }
        }
    }
}
