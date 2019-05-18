using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class OpenFileForm : Form
    {
       
        List<ns1.BunifuFlatButton> filenames = new List<ns1.BunifuFlatButton>();

        public OpenFileForm()
        {
            InitializeComponent();
            filename1.Click -= new System.EventHandler(this.filename1_Click);
            filename1.Click += new System.EventHandler(this.filename1_Click);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            filenames.Add(filename1);
            filenames.Add(filename2);
            filenames.Add(filename3);
            toolTip1.SetToolTip(bunifuFlatButton19, "Кликни на файл");




            int nomer_faila = 0;
            DirectoryInfo di = new DirectoryInfo(ReadNotesForm.PapkaSZemtkami);
            foreach (FileInfo fl in di.GetFiles())
            {
                if (fl.Extension == ".txt")
                {
                    filenames[nomer_faila].Text = fl.Name;
                    filenames[nomer_faila].Enabled = true;
                    filenames[nomer_faila].Click -= new System.EventHandler(this.filename1_Click);
                    filenames[nomer_faila].Click += new System.EventHandler(this.filename1_Click);
                    
                    nomer_faila = nomer_faila + 1;
                }
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
  

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filename1_Click(object sender, EventArgs e)
        {
            String fileName = ((ns1.BunifuFlatButton)sender).Text;

            ReadNotesForm dsfgdfg = new ReadNotesForm(fileName);
            dsfgdfg.Show();
        }


        private void bunifuFlatButton19_Click(object sender, EventArgs e)
        {

        }
    }
}
