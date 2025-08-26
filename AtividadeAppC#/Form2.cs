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

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double publicototal, rendatotal, rp, rg, ra, rc;

            publicototal = Convert.ToDouble(txtpublicototal.Text);

            rp = publicototal * 0.1 * 5;
            rg = publicototal * 0.5 * 10;
            ra = publicototal * 0.3 * 20;
            rc = publicototal * 0.1 * 30;

            rendatotal = rp + rg + ra + rc;

            txtrendatotal.Text = rendatotal.ToString();
        }
    }
}
