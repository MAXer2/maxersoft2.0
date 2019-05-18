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
    public partial class ReadNotesForm : Form
    {
        public const String PapkaSZemtkami = "C:\\Users\\student\\Desktop\\maxersoft-master\\notes files";
        String adres = "";

        public ReadNotesForm(String adresFaila)
        {
            InitializeComponent();

            richTextBox1.Lines = File.ReadAllLines(PapkaSZemtkami + "\\" + adresFaila);
            adres = adresFaila;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            File.WriteAllLines(PapkaSZemtkami + "\\" + adres, richTextBox1.Lines, System.Text.Encoding.UTF8);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            OpenForm dsfgdfg = new OpenForm();
            dsfgdfg.ShowDialog();
        }

        private void bunifuFlatButton17_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    

