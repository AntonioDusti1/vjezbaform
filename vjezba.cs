using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novo
{
    public partial class Form1 : Form
    {
        int ocjena, brojOcjena=0, zbroj;
        double prosjek;
        public Form1()
        {
            InitializeComponent();
        }

        private void txtunosOcjene_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ocjena = Convert.ToInt32(txtunosOcjene.Text);
            brojOcjena++;
            zbroj += ocjena;
            DialogResult odgovor= MessageBox.Show("Zelis li upisati jos ocjena?","Upit",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            switch (odgovor)
            {
                case DialogResult.Yes:
                    txtunosOcjene.Clear();
                    break;
                case DialogResult.No:
                    prosjek = (double)zbroj / brojOcjena;
                    textBox1.Text = prosjek.ToString();
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
