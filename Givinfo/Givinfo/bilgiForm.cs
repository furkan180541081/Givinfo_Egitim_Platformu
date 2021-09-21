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
    public partial class bilgiForm : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\Givinfo.mdb");
        public bilgiForm(string yetki)
        {
            InitializeComponent();
            if (yetki == "admin") { button1.Visible = true; button4.Visible = true; button5.Visible = true; button6.Visible = true; textBox1.ReadOnly = false; }
            OleDbCommand komut = new OleDbCommand("Select * from bilgiler", baglanti);
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int a = dt.Rows.Count;
            if (a != -1)
            {
                for (int i = 0; i < a; i++)
                    listBox1.Items.Add(dt.Rows[i]["baslik"].ToString());
            }
            baglanti.Close();
        }

        private void bilgiForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string baslik = listBox1.SelectedItem.ToString();
                OleDbCommand komut = new OleDbCommand("Select bilgi from bilgiler where baslik='" + baslik + "'", baglanti);
                OleDbCommand komut2 = new OleDbCommand("Select resim from bilgiler where baslik='" + baslik + "'", baglanti);
                baglanti.Open();
                textBox1.Text = komut.ExecuteScalar().ToString();
                pictureBox1.ImageLocation = Application.StartupPath + "/Resimler/" + komut2.ExecuteScalar().ToString();
                baglanti.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")
            {
                OleDbCommand mevcut_baslik = new OleDbCommand("Select * from bilgiler where baslik='" + textBox2.Text.Trim().Replace("'"," ") + "'", baglanti);
                baglanti.Open();
                OleDbDataReader a = mevcut_baslik.ExecuteReader();
                if (a.Read())
                {
                    MessageBox.Show("Bu Başlık Sistemde Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();
                }
                else
                {
                    pictureBox2.Image.Save(Application.StartupPath + "\\Resimler\\" + System.IO.Path.GetFileName(pictureBox2.ImageLocation));
                    OleDbCommand kayit = new OleDbCommand("Insert into bilgiler(baslik,bilgi,resim) values ('" + textBox2.Text.Trim().Replace("'", " ") + "','" + textBox3.Text.Trim().Replace("'"," ") + "','" + System.IO.Path.GetFileName(pictureBox2.ImageLocation) + "')", baglanti);
                    kayit.ExecuteNonQuery();
                    kayit.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Bilgi Ekleme Tamamlandı!", "Ekleme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Visible = false;
                    listBox1.Items.Add(textBox2.Text.Trim().Replace("'", " "));
                    listBox1.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.Title = "Resim Seçiniz";
            openFileDialog1.Filter = ("Jpeg Resim Dosyası (*.jpg)|*.jpg|Gif Resim Dosyası (*.gif)|*.gif|Bmp Resim Dosyası(*.bmp)|*.bmp|Tüm Dosyalar(*.*)|*.*");
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Lütfen Bilginin Başlığını Giriniz. Ekleyeceğiniz Resim İçin Yandaki Boş Alana Tıklayınız...")
            {
                textBox2.Text = null;
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.ForeColor = Color.Gray;
                textBox2.Text = "Lütfen Bilginin Başlığını Giriniz. Ekleyeceğiniz Resim İçin Yandaki Boş Alana Tıklayınız...";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Lütfen Ekleyeceğiniz Bilgiyi Giriniz...")
            textBox3.Text = null;
            textBox3.ForeColor = Color.Black;           
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.ForeColor = Color.Gray;
                textBox3.Text = "Lütfen Ekleyeceğiniz Bilgiyi Giriniz...";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                DialogResult a = MessageBox.Show("Bilgiyi Silmek İstediğinizden Emin Misiniz?", "Bilgiyi Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (a == DialogResult.Yes)
                {
                    OleDbCommand sil = new OleDbCommand("Delete * from bilgiler where baslik='" + listBox1.SelectedItem.ToString() + "'", baglanti);
                    OleDbCommand resimSil = new OleDbCommand("Select resim from bilgiler where baslik='" + listBox1.SelectedItem.ToString() + "'", baglanti);
                    baglanti.Open();
                    System.IO.File.Delete(Application.StartupPath + "/Resimler/" + resimSil.ExecuteScalar().ToString());
                    sil.ExecuteNonQuery();
                    sil.Dispose();
                    resimSil.Dispose();
                    baglanti.Close();
                    listBox1.Items.Remove(listBox1.SelectedItem.ToString());
                    listBox1.SelectedIndex = 0;
                    MessageBox.Show("Bilgi Başarıyla Silinmiştir...", "Bilgi Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Başlığı Seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && listBox1.SelectedIndex!=-1)
            {
                OleDbCommand guncelle = new OleDbCommand("Update bilgiler set bilgi='" + textBox1.Text.Trim() + "'where baslik='" + listBox1.SelectedItem.ToString() + "'", baglanti);
                baglanti.Open();
                guncelle.ExecuteNonQuery();
                guncelle.Dispose();
                baglanti.Close();
                MessageBox.Show("Bilgi Güncellendi!", "Bilgi Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen Bir Başlık Seçiniz ve Bilgi Alanını Boş Bırakmayınız!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                panel2.Visible = true;
                textBox4.Text = listBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Başlık Seçiniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Insert(index,textBox4.Text.Trim().Replace("'",""));
            OleDbCommand guncelle = new OleDbCommand("Update bilgiler set baslik='" + textBox4.Text.Trim().Replace("'","") + "'where bilgi='" + textBox1.Text + "'", baglanti);
            baglanti.Open();
            guncelle.ExecuteNonQuery();
            guncelle.Dispose();
            baglanti.Close();
            MessageBox.Show("Başlık Güncellendi!", "Başlık Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panel2.Visible = false;
        }
    }
}
