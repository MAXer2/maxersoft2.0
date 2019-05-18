using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            webBrowser2.Url = new Uri("https://m.vk.com");
            webBrowser1.Url = new Uri("https://youtube.com");
            webBrowser4.Url = new Uri("https://vk.com");
            webBrowser3.Url = new Uri("https://youtube.com");
            webBrowser5.Url = new Uri("https://google.com");
            this.Controls.Clear();
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
            this.Controls.Add(trackBar1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
            this.Controls.Add(trackBar1);
            this.Controls.Add(webBrowser4);
            this.Controls.Add(webBrowser3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(button1);
            this.Controls.Add(button2);
            this.Controls.Add(button3);
            this.Controls.Add(webBrowser1);
            this.Controls.Add(webBrowser2);
        }

     

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            webBrowser3.Width = Convert.ToInt16(480 + trackBar1.Value);
            webBrowser3.Height = Convert.ToInt16(261 + trackBar1.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Add(webBrowser5);
        }
    }
}
