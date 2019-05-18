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
    public partial class GalleryForm : Form
    {
        public GalleryForm()
        {
            InitializeComponent();

            this.Controls.Clear();
            this.Controls.Add(bunifuTileButton2);
            this.Controls.Add(bunifuTileButton1);
            this.Controls.Add(bunifuFlatButton17); 
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

            this.Controls.Clear();
            this.Controls.Add(pictureBox2);
            this.Controls.Add(bunifuTileButton2);
            this.Controls.Add(bunifuTileButton1);
            this.Controls.Add(bunifuFlatButton17); 
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(pictureBox1);
            this.Controls.Add(bunifuTileButton2);
            this.Controls.Add(bunifuTileButton1);
            this.Controls.Add(bunifuFlatButton17); 
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
