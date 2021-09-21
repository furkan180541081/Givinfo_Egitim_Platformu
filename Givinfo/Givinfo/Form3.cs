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

namespace Givinfo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            string[] dosyalar = Directory.GetFiles(Application.StartupPath + "/Oyunlar");
            foreach (string oyun in dosyalar)
            {
                if (oyun.EndsWith(".swf"))
                    listBox1.Items.Add(Path.GetFileName(oyun).Remove(Path.GetFileName(oyun).Length - 4, 4));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string isim = listBox1.SelectedItem.ToString();
            axShockwaveFlash1.Movie = Application.StartupPath + "/Oyunlar/" + isim + ".swf";
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            oyunForm a = Application.OpenForms["oyunForm"] as oyunForm;
            a.Show();
        }
    }
}
