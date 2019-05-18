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
    public partial class CalculatorForm : Form
    {
        int chislo1 = 0;
        int chislo2 = 0;

        string operation = "";
        public CalculatorForm()
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


        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            String buttonText = ((ns1.BunifuFlatButton)sender).Text;
            //Если операция пустая, увеличиваем число
            if (operation == "")
            {
                chislo1 = Convert.ToInt32(resultLabel.Text + buttonText);
                resultLabel.Text = chislo1.ToString();
            }
            //Если она выбрана, умножаем / делим и т.д.
            else
            {
                chislo2 = Convert.ToInt32(resultLabel.Text + buttonText);
                resultLabel.Text = chislo2.ToString();
            }
        }
        void operationCalc()
        {
            if (operation == "вычитать")
            {
                chislo1 = (chislo1 - chislo2);
            }
            else if (operation == "сложить")
            {
                chislo1 = (chislo1 + chislo2);
            }
            else if (operation == "делить")
            {
                chislo1 = (chislo1 / chislo2);
            }
            else if (operation == "умножить")
            {
                chislo1 = (chislo1 * chislo2);
            }

        }
        private void bunifuFlatButton2_Click_1(object sender, EventArgs e)
        {
            operationCalc();

            operation = "сложить";
            resultLabel.Text = "";            
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {

             operationCalc();

            operation = "делить";
            resultLabel.Text = "";
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            operationCalc();
            operation = "вычитать";
            resultLabel.Text = "";
        }

        private void ravnoButton_Click(object sender, EventArgs e)
        {
            if (operation == "вычитать")
            {
                resultLabel.Text = (chislo1 - chislo2).ToString();
            }
            else if (operation == "сложить")
            {
                resultLabel.Text = (chislo1 + chislo2).ToString();
            }
            else if (operation == "делить")
            {
                resultLabel.Text = (chislo1 / chislo2).ToString();
            }
            else if (operation == "умножить")
            {
                resultLabel.Text = (chislo1 * chislo2).ToString();
            }

            operation = "";
        }

        private void bunifuFlatButton16_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
        }

        private void umnojitButtonClick(object sender, EventArgs e)
        {
            operationCalc();
            operation = "умножить";
            resultLabel.Text = "";
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
