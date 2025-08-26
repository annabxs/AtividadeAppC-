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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void tsmi1_Click(object sender, EventArgs e)
        {
            frmexercicio1 frmexercicio1 = new frmexercicio1();
            Hide();
            frmexercicio1.Show();

        }

        private void tsmi2_Click(object sender, EventArgs e)
        {
            frmexercicio2 frmexercicio2 = new frmexercicio2();
            Hide();
            frmexercicio2.Show();
        }

        private void tsmi3_Click(object sender, EventArgs e)
        {
            frmexercicio3 frmexercicio3 = new frmexercicio3();
            Hide();
            frmexercicio3.Show();
        }

        private void tsmi4_Click(object sender, EventArgs e)
        {
            frmexercicio4 frmexercicio4 = new frmexercicio4();
            Hide();
            frmexercicio4.Show();
        }

        private void tsmi5_Click(object sender, EventArgs e)
        {
            frmexercicio5 frmexercicio5 = new frmexercicio5();
            Hide();
            frmexercicio5.Show();
        }
    }
}
