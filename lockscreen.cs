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
    public partial class lockscreen : Form
    {
        public lockscreen()
        {           
            InitializeComponent();
        }
       
        private void lockscreen_Load(object sender, EventArgs e)
        {            
            this.Controls.Clear();
            this.Controls.Add(bunifuGradientPanel1);
            this.Controls.Add(button2);
            this.Controls.Add(signupButton);
            this.Controls.Add(button3);
            this.Controls.Add(button1);


            string[] stroki2 = File.ReadAllLines("login.txt");

            for (int nomer = 0; nomer < stroki2.Length; nomer = nomer + 4)
            {
                String login = stroki2[nomer + 1];
                String password = stroki2[nomer + 2];
                String nom = stroki2[nomer + 3];

                if (nomer == 0)
                {
                    button1.Tag = login;
                    button1.Text = password;
                }
                else if (nomer == 1)
                {
                    button2.Tag = login;
                    button2.Text = password;
                }
            }
        }
        

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //this.Controls.Clear();
            //this.Controls.Add(bunifuFlatButton2);   
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            string[] stroki2 = File.ReadAllLines("login.txt");

            bool polzovatelNaiden = false;
            for (int nomer = 0; nomer < stroki2.Length; nomer = nomer + 4)
            {
                String login = stroki2[nomer + 1];
                String password = stroki2[nomer + 2];
                String nom = stroki2[nomer + 3];

                if ((passwordTextBox.Text == password) && (loginTextbox1.Text == login))
                {
                    polzovatelNaiden = true;
                }
            }

            if (polzovatelNaiden)
            {
                MainForm f = new MainForm();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверные данные");
            }
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            SingUpForm g = new SingUpForm();
            g.ShowDialog();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void loginTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Add(bunifuFlatButton1);
            this.Controls.Add(signupButton);
            this.Controls.Add(bunifuFlatButton4);
            this.Controls.Add(bunifuFlatButton5);
            int x = bunifuFlatButton1.Location.X;
            int y = bunifuFlatButton1.Location.Y;
            

            /// bunifuFlatButton1.Location = new System.Drawing.Point(x + 50, y);
            ///  System.Threading.Thread.Sleep(1000);

            this.Controls.Add(passwordTextBox);

            this.Controls.Add(loginTextbox1);
            loginTextbox1.Text = ((Button)sender).Tag.ToString();

            //bunifuFlatButton1_Click_1(sender, e);
        }
    }
}
