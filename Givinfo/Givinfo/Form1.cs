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

namespace Givinfo
{
    public partial class Form1 : Form
    {
        string _url;
        public string VideoID
        {
            get
            {
                var yMatch = new Regex(@"http(?:s?)://(?:www\.)?youtu(?:be\.com/watch\?v=|\.be/)([\w\-]+)(&(amp;)?[\w\?=]*)?").Match(_url);
                return yMatch.Success ? yMatch.Groups[1].Value : String.Empty;
            }
        }
        public Form1(string link)
        {
            InitializeComponent();
            _url = link;
            webBrowser1.DocumentText = String.Format("<html><head>" +
                    "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                    "</head><body>" +
                    "<iframe width=\"100%\" height=\"700\" src=\"https://www.youtube.com/embed/{0}?autoplay=1\"" +
                    "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                    "</body></html>", VideoID);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms["videoForm"] != null)
            {
                videoForm a = Application.OpenForms["videoForm"] as videoForm;
                a.Show();
                a.listBox1.SelectedIndex = -1;
                
            }
        }
    }
}
