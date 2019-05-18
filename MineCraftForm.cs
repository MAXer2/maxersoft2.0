using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        bool isDown = false;
        bool isDown2 = false;
        public Form1()
        {
            InitializeComponent();
            trackBar1.Scroll += trackBar1_Scroll;

            trackBar2.Scroll += trackBar2_Scroll;
            this.Controls.Add(trackBar1);
            this.Controls.Add(trackBar2);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(panel1);
        
           
        }


        int VKLADKA = 2;
        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (VKLADKA == 1) {
            pictureBox1.Width = Convert.ToInt16(164 + trackBar1.Value);
            }
            else if (VKLADKA == 2)
            {
                pictureBox2.Width = Convert.ToInt16(164 + trackBar1.Value);
            }

        }

        private void trackBar2_Scroll(object sender, EventArgs e) {
            if (VKLADKA == 1)
            {
                pictureBox1.Height = Convert.ToInt16(104 + trackBar2.Value);
            }
            if (VKLADKA == 2)
            {
                pictureBox2.Height = Convert.ToInt16(104 + trackBar2.Value);
            }
          
        }
       
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        Bitmap sub_image;
       
        private void button4_Click(object sender, EventArgs e)
        {
            sub_image = new Bitmap(@"маин6.png", true);
            pictureBox1.Image = sub_image;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sub_image = new Bitmap("C:\\Users\\Student\\Desktop\\maxersoft-master\\майн.png", true);
            pictureBox1.Image = sub_image;
        }

       

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {

            isDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (isDown && Control.MousePosition.X < 350 && Control.MousePosition.Y < 650)
            {

                c.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            isDown2 = true;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {

            Control c = sender as Control;
            if (isDown2 && Control.MousePosition.X < 484 && Control.MousePosition.Y < 500)
            {

                c.Location = this.PointToClient(Control.MousePosition);
            }
        
    }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            isDown2 = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            sub_image = new Bitmap(@"майн3.png", true);
            pictureBox2.Image = sub_image;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sub_image = new Bitmap(@"майн7.png", true);
            pictureBox2.Image = sub_image;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            panel3.Controls.Clear();
            this.Controls.Add(trackBar1);
            this.Controls.Add(trackBar2);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button5);
          
            VKLADKA = 1;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            this.Controls.Add(trackBar1);
            this.Controls.Add(trackBar2);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(trackBar1);
            panel3.Controls.Add(trackBar2);


            VKLADKA = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
