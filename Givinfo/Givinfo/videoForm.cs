using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.OleDb;

namespace Givinfo
{
    public partial class videoForm : Form
    {
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "\\Givinfo.mdb");
        public videoForm(string yetki)
        {
            InitializeComponent();
            if (yetki == "admin") { listBox1.Height = 469; button1.Visible = true; button3.Visible = true; }
            OleDbCommand komut = new OleDbCommand("Select * from linkler", baglanti);
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            int a = dt.Rows.Count;
            if (a != -1)
            {
                for (int i = 0; i < a; i++)
                    listBox1.Items.Add(dt.Rows[i]["isim"].ToString());
            }
            baglanti.Close();
        }
        string Url;
        public string VideoID
        {
            get
            {
                var yMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(Url);
                return yMatch.Success ? yMatch.Groups[1].Value : string.Empty;
            }
        }
        private void videoForm_FormClosing(object sender, FormClosingEventArgs e)
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

        public void ac(string gonderilen)
        {
            Url = gonderilen;
            webBrowser1.DocumentText = String.Format("<meta http-equiv='X-UA-Compatible' content='IE=Edge'/><iframe width='640' height='490'" +
                " src='https://www.youtube.com/embed/{0}?autoplay=1' frameborder='0' allow='accelerometer; autoplay;" +
                " encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>", VideoID);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex!=-1){
                string ad = listBox1.SelectedItem.ToString();
                OleDbCommand komut = new OleDbCommand("Select link from linkler where isim='" + ad + "'", baglanti);
                baglanti.Open();
                string link = komut.ExecuteScalar().ToString();
                baglanti.Close();
                ac(link);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            panel1.Visible = true;
            webBrowser1.Stop();
            webBrowser1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox2.Text.Trim().StartsWith("http"))
            {
                OleDbCommand mevcut_link = new OleDbCommand("Select * from linkler where link='" + textBox2.Text.Trim() + "'", baglanti);
                baglanti.Open();
                OleDbDataReader a = mevcut_link.ExecuteReader();
                if (a.Read())
                {
                    MessageBox.Show("Bu Link Sistemde Kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    baglanti.Close();
                }
                else
                {
                    OleDbCommand kayit = new OleDbCommand("Insert into linkler(isim,link) values ('" + textBox1.Text.Trim().Replace("'", "") + "','" + textBox2.Text.Trim() + "')", baglanti);
                    kayit.ExecuteNonQuery();
                    kayit.Dispose();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Tamamlandı!", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel1.Visible = false;
                    listBox1.Items.Add(textBox1.Text.Trim().Replace("'", ""));
                    listBox1.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Boş Alan Bırakmayınız veya Link Kısmını Kontrol Ediniz!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            webBrowser1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string silinecek_video = listBox1.SelectedItem.ToString();
            OleDbCommand komut1 = new OleDbCommand("Delete * from linkler where isim='" + silinecek_video + "'", baglanti);
            baglanti.Open();
            komut1.ExecuteNonQuery();
            komut1.Dispose();
            baglanti.Close();
            listBox1.Items.Remove(silinecek_video);
            listBox1.SelectedIndex = 0;
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                webBrowser1.Stop();
                this.Hide();
                string ad = listBox1.SelectedItem.ToString();
                OleDbCommand komut = new OleDbCommand("Select link from linkler where isim='" + ad + "'", baglanti);
                baglanti.Open();
                string link = komut.ExecuteScalar().ToString();
                baglanti.Close();
                Form1 form = new Form1(link);
                form.Text = ad;
                form.ShowDialog();
            }
        }
    }
}
