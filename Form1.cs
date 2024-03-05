using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProsjekOcjena
{
    public partial class Form1 : Form
    {
        int ocjena, brojOcjena = 0, zbroj = 0;
        double prosjek;

        private void txtZbroj_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            try
            {
                ocjena = Convert.ToInt32(txtUnosOcjene.Text);
                if (ocjena != 1 )
                {
                    brojOcjena++;
                    txtBrojOcjene.Text = brojOcjena.ToString();
                    zbroj += ocjena;
                    txtZbroj.Text = zbroj.ToString();
                    DialogResult odgovor = MessageBox.Show("Želiš li upisati još ocjena?", "Upit",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (odgovor)
                    {
                        case DialogResult.Yes:
                            txtUnosOcjene.Clear();
                            txtUnosOcjene.Focus();
                            break;
                        case DialogResult.No:
                            prosjek = (double)zbroj / brojOcjena;
                            txtProsjek.Text = prosjek.ToString();
                            break;
                    }
                }
                else if (ocjena == 0)
                {
                    MessageBox.Show("Imas negativnu ocjena,ispravi je prije nego " +
                         "da","Pogrsan unos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Imas negativnu ocjena,ispravi je prije nego " +
                        "ides racunati prosjek!", "NEGATIVNO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception greska)
            {
                MessageBox.Show(greska.Message, "Greska unosa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
