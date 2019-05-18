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
    public partial class SingUpForm : Form
    {
        public SingUpForm()
        {
            InitializeComponent();
        }
        string login;
        string password ;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            login = loginTextbox.Text;
            password = passwordTextbox.Text;
            File.AppendAllText("login.txt", loginTextbox.Text + Environment.NewLine +
                                            passwordTextbox.Text + Environment.NewLine +
                                            nomerTextbox.Text + Environment.NewLine + 
                                            Environment.NewLine, System.Text.Encoding.UTF8);

            MessageBox.Show("Сохранено");
            Close();
        }

        private void SIngUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {

          
       
        }

        private void bunifuMetroTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            lockscreen j = new lockscreen();
            j.Show();
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
