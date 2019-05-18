using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(exitPanel);
            this.Controls.Add(menuPanel);
           
            richTextBox1.Lines = File.ReadAllLines("../../2131.txt");
            /*textBox1.Text = "Ваня, брось рисовать";
            textBox1.Size = new Size(450, 50);

            button.BackColor = Color.Maroon;
            button.Font = new Font("Arial", 12);*/
        }

        private void butt_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ваня, да утихни уже!!!");

            richTextBox1.AppendText(textBox1.Text + "\n");

            /*if (textBox1.Text == "Привет")
            {
                richTextBox1.AppendText("Здравствуйте" + "\n");
            }
            else if (textBox1.Text == "Как дела?")
            {
                richTextBox1.AppendText("норм" + "\n");
            }*/

            switch (textBox1.Text)
            {
                case "Привет":


                    System.Threading.Thread.Sleep(500);
               
                    richTextBox1.AppendText("Здравствуйте"+ "\n");
                    
                    break;
                case "Пока":
                    richTextBox1.AppendText("прощайте,сударь" + "\n");
                    break;
                case "Как дела?":
                    richTextBox1.AppendText("норм" + "\n");
                    break;
                case "ты даун":
                    richTextBox1.AppendText("сам ты даун " + "\n");
                    break;

                case "Расскажи анекдот":
                    richTextBox1.AppendText("Самую большую щуку весом в 50 килограмм, поймал рыболов из Рязани. Это на 7 кг больше, чем нап@здел предыдущий рекордсмен." + "\n");
                    break;

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CalculatorForm dsfgdfg = new CalculatorForm();
            dsfgdfg.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Close();  

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.Controls.Add(exitPanel);
         
            this.Controls.Add(button);
            this.Controls.Add(richTextBox1);
            this.Controls.Add(textBox1);
            this.Controls.Add(menuPanel);           
     
           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
           
           this.Controls.Clear();
           this.Controls.Add(exitPanel);
           this.Controls.Add(menuPanel);
       
           this.Controls.Add(bunifuTileButton1);
             this.Controls.Add(bunifuTileButton2);
             this.Controls.Add(bunifuTileButton3);
             this.Controls.Add(bunifuTileButton4);
            this.Controls.Add(bunifuTileButton5);
            this.Controls.Add(ButtonVk);
             this.Controls.Add(ButtonDc);
        
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
          
            this.Controls.Add(exitPanel);
            this.Controls.Add(menuPanel);
   
            this.Controls.Add(Dropdown1);
        }

        private void Dropdown1_onItemSelected(object sender, EventArgs e)
        {
            RedactorForm hghytu = new RedactorForm();
            hghytu.ShowDialog();
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            CalculatorForm dsfgdfg = new CalculatorForm();
            dsfgdfg.ShowDialog();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            GaleryForm dsfgdfg = new GaleryForm();
            dsfgdfg.ShowDialog();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            Form7 dsfgdfg = new Form7();
            dsfgdfg.ShowDialog();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            OpenForm dsfgdfg = new OpenForm();
            dsfgdfg.ShowDialog();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Environment.CurrentDirectory);
            Process.Start(Environment.CurrentDirectory + "/PersRedactor.exe");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("h:mm:ss");
        }

        private void ButtonVk_Click(object sender, EventArgs e)
        {
            

            //Process.Start("https://vk.com/feed");
        }

        private void ButtonDc_Click(object sender, EventArgs e)
        {
            Process.Start("https://discordapp.com/");
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            lockscreen dsfgdfg = new lockscreen();
            dsfgdfg.Show();
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            DrawingForm dsfgdfg = new DrawingForm();
            dsfgdfg.Show();
        }

        private void bunifuTileButton5_Click_1(object sender, EventArgs e)
        {
            DrawingForm dsfgdfg = new DrawingForm();
            dsfgdfg.Show();
        }

        private void bunifuFlatButton6_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
