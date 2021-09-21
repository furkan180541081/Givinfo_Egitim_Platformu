using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Givinfo
{
    public partial class Form2 : Form
    {
        int sayi1, sayi2, sonuc;
        double kontrol;
        public Form2(string k_adi)
        {
            InitializeComponent();
            label8.Text = "Hoşgelgin " + k_adi.ToUpper() + " Başarılar...";
            label6.Text = "";
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Name == "Node4") // 1 Basamaklı Toplama
            {
                label2.Text = "+";
                button1.Text = "1 Basamaklı Toplama İşlemi Üret";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label10.Visible = false;
                label11.Visible = false;
            }
            if (treeView1.SelectedNode.Name == "Node5") // 2 Basamaklı Toplama
            {
                label2.Text = "+";
                button1.Text = "2 Basamaklı Toplama İşlemi Üret";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label10.Visible = false;
                label11.Visible = false;
            }
            if (treeView1.SelectedNode.Name == "Node6") // 3 Basamaklı Toplama
            {
                label2.Text = "+";
                button1.Text = "3 Basamaklı Toplama İşlemi Üret";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label10.Visible = false;
                label11.Visible = false;
            }
            if (treeView1.SelectedNode.Name == "Node7") // 1 Basamaklı Çıkarma
            {
                label2.Text = "-";
                button1.Text = "1 Basamaklı Çıkarma İşlemi Üret";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label10.Visible = false;
                label11.Visible = false;
            }
            if (treeView1.SelectedNode.Name == "Node8") // 2 Basamaklı Çıkarma
            {
                label2.Text = "-";
                button1.Text = "2 Basamaklı Çıkarma İşlemi Üret";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label10.Visible = false;
                label11.Visible = false;
            }
            if (treeView1.SelectedNode.Name == "Node9") // 3 Basamaklı Çıkarma
            {
                label2.Text = "-";
                button1.Text = "3 Basamaklı Çıkarma İşlemi Üret";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label10.Visible = false;
                label11.Visible = false;
            }
            if (treeView1.SelectedNode.Name == "Node10") // 1 Basamaklı Çarpma
            {
                label2.Text = "*";
                button1.Text = "1 Basamaklı Çarpma İşlemi Üret";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label10.Visible = false;
                label11.Visible = false;
            }
            if (treeView1.SelectedNode.Name == "Node11") // 2 Basamaklı Çarpma
            {
                label2.Text = "*";
                button1.Text = "2 Basamaklı Çarpma İşlemi Üret";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label10.Visible = false;
                label11.Visible = false;
            }
            if (treeView1.SelectedNode.Name == "Node12") // 3 Basamaklı Çarpma
            {
                label2.Text = "*";
                button1.Text = "3 Basamaklı Çarpma İşlemi Üret";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label10.Visible = false;
                label11.Visible = false;
            }
            if (treeView1.SelectedNode.Name == "Node13") // 1 Basamaklı Bölme
            {
                label2.Text = "/";
                button1.Text = "1 Basamaklı Bölme İşlemi Üret";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label10.Visible = true;
                label11.Visible = true;
            }
            if (treeView1.SelectedNode.Name == "Node14") // 2 Basamaklı Bölme
            {
                label2.Text = "/";
                button1.Text = "2 Basamaklı Bölme İşlemi Üret";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label10.Visible = true;
                label11.Visible = true;
            }
            if (treeView1.SelectedNode.Name == "Node15") // 3 Basamaklı Bölme
            {
                label2.Text = "/";
                button1.Text = "3 Basamaklı Bölme İşlemi Üret";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                label10.Visible = true;
                label11.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) // Rastgele sayı üretme ve ekrana yazdırma bölümü
        {
            label6.Text = ""; label6.BackColor = Color.Yellow;
            if ((treeView1.SelectedNode.Name == "Node4") || (treeView1.SelectedNode.Name == "Node5") || (treeView1.SelectedNode.Name == "Node6") || (treeView1.SelectedNode.Name == "Node7") || (treeView1.SelectedNode.Name == "Node8") || (treeView1.SelectedNode.Name == "Node9") || (treeView1.SelectedNode.Name == "Node10") || (treeView1.SelectedNode.Name == "Node11") || (treeView1.SelectedNode.Name == "Node12") || (treeView1.SelectedNode.Name == "Node13") || (treeView1.SelectedNode.Name == "Node14") || (treeView1.SelectedNode.Name == "Node15"))
            {
                if ((treeView1.SelectedNode.Name == "Node4") || (treeView1.SelectedNode.Name == "Node7") || (treeView1.SelectedNode.Name == "Node10") || (treeView1.SelectedNode.Name == "Node13"))
                {
                    // 1 Basamaklı rastgele sayı üretme ve ekrana yazdırma bölümü
                    Random rnd = new Random();
                    sayi1 = rnd.Next(1, 9);
                    sayi2 = rnd.Next(1, 9);
 
                    if (sayi1 > sayi2)
                    {
                        textBox1.Text = sayi1.ToString();
                        textBox2.Text = sayi2.ToString();
                    }
                    else
                    {
                        textBox1.Text = sayi2.ToString();
                        textBox2.Text = sayi1.ToString();
                    }
                }
 
                if ((treeView1.SelectedNode.Name == "Node5") || (treeView1.SelectedNode.Name == "Node8") || (treeView1.SelectedNode.Name == "Node11") || (treeView1.SelectedNode.Name == "Node14"))
                {
                    // 2 Basamaklı rastgele sayı üretme ve ekrana yazdırma bölümü
                    Random rnd = new Random();
                    sayi1 = rnd.Next(10, 99);
                    sayi2 = rnd.Next(10, 99);
 
                    if (sayi1 > sayi2)
                    {
                        textBox1.Text = sayi1.ToString();
                        textBox2.Text = sayi2.ToString();
                    }
                    else
                    {
                        textBox1.Text = sayi2.ToString();
                        textBox2.Text = sayi1.ToString();
                    }
                }
 
                if ((treeView1.SelectedNode.Name == "Node6") || (treeView1.SelectedNode.Name == "Node9") || (treeView1.SelectedNode.Name == "Node12") || (treeView1.SelectedNode.Name == "Node15"))
                {
                    // 3 Basamaklı rastgele sayı üretme ve ekrana yazdırma bölümü
                    Random rnd = new Random();
                    sayi1 = rnd.Next(100, 999);
                    sayi2 = rnd.Next(100, 999);
 
                    if (sayi1 > sayi2)
                    {
                        textBox1.Text = sayi1.ToString();
                        textBox2.Text = sayi2.ToString();
                    }
                    else
                    {
                        textBox1.Text = sayi2.ToString();
                        textBox2.Text = sayi1.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen Soldaki Menüden Bir İşlem Seçiniz...","İşlem Seçimi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            oyunForm a = Application.OpenForms["oyunForm"] as oyunForm;
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e) // Sonuç hesaplama bölümü
        {
            int i;
            if ((textBox1.Text != "") || (textBox2.Text != ""))
            {
                if (int.TryParse(textBox3.Text, out i))  // Girilen ifadenin rakam olup olmadığını kontrol ediyor.
                {
                    if ((treeView1.SelectedNode.Name == "Node4") || (treeView1.SelectedNode.Name == "Node5") || (treeView1.SelectedNode.Name == "Node6"))
                    {
                        sonuc = sayi1 + sayi2;
                        kontrol = Convert.ToDouble(textBox3.Text);
                    }

                    if ((treeView1.SelectedNode.Name == "Node7") || (treeView1.SelectedNode.Name == "Node8") || (treeView1.SelectedNode.Name == "Node9"))
                    {
                        if (sayi1 > sayi2)
                        {
                            sonuc = sayi1 - sayi2;
                            kontrol = Convert.ToDouble(textBox3.Text);
                        }
                        else
                        {
                            sonuc = sayi2 - sayi1;
                            kontrol = Convert.ToDouble(textBox3.Text);
                        }
                    }

                    if ((treeView1.SelectedNode.Name == "Node10") || (treeView1.SelectedNode.Name == "Node11") || (treeView1.SelectedNode.Name == "Node12"))
                    {
                        sonuc = sayi1 * sayi2;
                        kontrol = Convert.ToDouble(textBox3.Text);
                    }

                    if ((treeView1.SelectedNode.Name == "Node13") || (treeView1.SelectedNode.Name == "Node14") || (treeView1.SelectedNode.Name == "Node15"))
                    {


                        if (sayi1 > sayi2)
                        {
                            sonuc = sayi1 / sayi2;
                            kontrol = Convert.ToInt16(textBox3.Text);
                            label11.Text = (sayi1 % sayi2).ToString();
                        }
                        else
                        {
                            sonuc = sayi2 / sayi1;
                            kontrol = Convert.ToInt16(textBox3.Text);
                            label11.Text = (sayi2 % sayi1).ToString();
                        }
                    }

                    if (sonuc == kontrol)
                    {
                        label6.Font= new Font("Microsoft Sans Serif",20,FontStyle.Bold);
                        label6.Text = "Sonuç\nDoğru";
                        label6.BackColor = Color.Green;
                        label12.Visible = false;
                    }
                    else
                    {
                        label6.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                        label6.Text = "Sonuç Yanlış";
                        label6.BackColor = Color.Red;
                        label12.Visible = true;
                        label12.Text = "Sonuç: " + sonuc.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen Sonuç Rakamını Yazınız...","Sonuç Yazın",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Önce Rastgele Sayıları Üretin!","Rasgele Sayı Üret", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}