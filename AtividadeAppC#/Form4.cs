using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAppC_
{
    public partial class frmexercicio3 : Form
    {
        public frmexercicio3()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double VU, P, LC;

            LC = Convert.ToDouble(txtquantidadelivros.Text);

            if (LC < 10)
            {
                VU = 12;
            }
            else
            {
                VU = 8;
            }

            P = LC * VU;
            txttotalpago.Text = P.ToString(); 
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            menu.Show();
            this.Hide();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtquantidadelivros.Clear();
            txttotalpago.Clear();
            txtquantidadelivros.Focus();
        }
    }
}
