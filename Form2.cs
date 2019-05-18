using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        int chislo = 0;
        string str = "dsfsdf";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.donationalerts.com/r/xmaxer");

          //  this.Controls.Clear();
         //   this.Controls.Add(button1);
           // this.Controls.Add(button2);
           // this.Controls.Add(panel3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://livesubs.ru/#!/UCAUl1pLOVsQ2VeEm530oitg");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            chislo = 1;
            label2.Text = chislo.ToString();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            chislo = 2;
            label2.Text = chislo.ToString();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            chislo = 3;
            label2.Text = chislo.ToString();
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            chislo = 4;
            label2.Text = chislo.ToString();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            chislo = 5;
            label2.Text = chislo.ToString();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            chislo = 6;
            label2.Text = chislo.ToString();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {

            chislo =7;
            label2.Text = chislo.ToString();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {

            chislo = 8;
            label2.Text = chislo.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            chislo = 9;
            label2.Text = chislo.ToString();
        }

        private void bunifuFlatButton14_Click(object sender, EventArgs e)
        {

            chislo = 0;
            label2.Text = chislo.ToString();
        }
    }
}
