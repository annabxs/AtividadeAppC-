using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAppC_
{
    public partial class frmexercicio2 : Form
    {
        public frmexercicio2()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double idade, salario, abono;
            char sexo;
            string nome;

            nome = txtnome.Text;
            sexo = Convert.ToChar(txtsexo.Text);
            idade = Convert.ToDouble(txtidade.Text);
            salario = Convert.ToDouble(txtsalario.Text);

            if (sexo.Equals("M"))
                if (idade >= 30)
                    abono = salario + 100;
            
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttotalpago_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltotalpago_Click(object sender, EventArgs e)
        {

        }
    }
}
