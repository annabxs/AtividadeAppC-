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
    public partial class frmexercicio5 : Form
    {
        public frmexercicio5()
        {
            InitializeComponent();
        }

        private void lblpeso_Click(object sender, EventArgs e)
        {

        }

        private void txtpeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtaltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblaltura_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;

            peso = Convert.ToDouble(txtpeso.Text);
            altura = Convert.ToDouble(txtaltura.Text);

            imc = Math.Round(peso / Math.Pow(altura, 2), 2);

            if (imc < 17)
                txtresultado.Text = "Seu IMC é de " + imc + " e se enquadra em magreza severa.";
            else if (imc >= 17 && imc < 18.5)
                txtresultado.Text = "Seu IMC é de " + imc + " e se enquadra em magreza leve.";
            else if (imc >= 18.5 && imc < 25)
                txtresultado.Text = "Seu IMC é de " + imc + " e se enquadra em peso normal.";
            else if (imc >= 25 && imc < 30)
                txtresultado.Text = "Seu IMC é de " + imc + " e se enquadra em sobrepeso.";
            else if (imc >= 30 && imc < 35)
                txtresultado.Text = "Seu IMC é de " + imc + " e se enquadra em obesidade classe I.";
            else if (imc >= 35 && imc < 40)
                txtresultado.Text = "Seu IMC é de " + imc + " e se enquadra em obesidade classe II.";
            else
                txtresultado.Text = "Seu IMC é de " + imc + " e se enquadra em obesidade classe III.";
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtpeso.Clear();
            txtaltura.Clear();
            txtresultado.Clear();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            menu.Show();
            Hide();
        }
    }
}
