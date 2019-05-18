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
    public partial class SIngUpForm : Form
    {
        public SIngUpForm()
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
            login = bunifuMetroTextbox2.Text;
            password = bunifuMetroTextbox1.Text;
            File.WriteAllText("nomera.txt", bunifuMetroTextbox3.Text, System.Text.Encoding.UTF8);
            File.WriteAllText("passwords.txt" , bunifuMetroTextbox1.Text, System.Text.Encoding.UTF8);
            File.WriteAllText("login.txt", bunifuMetroTextbox2.Text, System.Text.Encoding.UTF8);
            MessageBox.Show("Сохранено");
        }

        private void SIngUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            MessageBox.Show("пока " + login);
       
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
