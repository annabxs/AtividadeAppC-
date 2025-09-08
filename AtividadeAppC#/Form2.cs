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
    public partial class frmexercicio1 : Form
    {
        public frmexercicio1()
        {
            InitializeComponent();
        }

        double publicototal, rendatotal, pp, pg, pa, pc, rp, rg, ra, rc;

        private void btncalcular_Click(object sender, EventArgs e)
        {

            publicototal = Convert.ToDouble(txtpublicototal.Text);

            pp = publicototal * 0.1;
            pg = publicototal * 0.5;
            pa = publicototal * 0.3;
            pc = publicototal * 0.1;

            if (pp > 0)
                rp = pp * 5;
            if (pg > 0)
                rg = pg * 10;
            if (pa > 0)
                ra = pa * 20;
            if (pc > 0)
                rc = pc * 30;

            rendatotal = rp + rg + ra + rc;

            txtrendatotal.Text = rendatotal.ToString();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtpublicototal.Clear();
            txtrendatotal.Clear();
            txtpublicototal.Focus();    
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu(); 
            menu.Show();
            this.Hide();
        }
    }
}
