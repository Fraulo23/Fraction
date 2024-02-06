using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fraction
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomma_Click(object sender, EventArgs e)
        {
            Fraction somma = Fraction.Parse(lstFrazioni.Items[0].ToString());
            foreach (Fraction f in lstFrazioni.Items)
            {
                if (f != lstFrazioni.Items[0])
                {
                    somma = somma.Somma(f);
                }
            }
            lblRisultato.Text = somma.ToString();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            Fraction f = Fraction.Parse(txtN.Text);
            lstFrazioni.Items.Add(f);
        }

        private void btnPulisci_Click(object sender, EventArgs e)
        {
            lstFrazioni.Items.Clear();
        }
    }
}
