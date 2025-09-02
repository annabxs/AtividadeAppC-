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

        double idade, salario2, salario, aumento;
        string nome, sexo;
        private void btncalcular_Click(object sender, EventArgs e)
        {

            bool isNumeric = double.TryParse(txtidade.Text, out idade);
            if (!isNumeric)
            {
                MessageBox.Show("Por favor, insira um valor numérico válido para a idade.");
                return; // Sai do método se a conversão falhar
            }
             isNumeric = double.TryParse(txtsalario.Text, out salario);
            
            nome = txtnome.Text;
            sexo = txtsexo.Text;
            idade = Convert.ToDouble(txtidade.Text);
            salario = Convert.ToDouble(txtsalario.Text);

            if (sexo.Equals("M"))
                if (idade >= 30)
                    aumento = 100;
                else
                    aumento = 50;
                
            else if (sexo.Equals("F"))
                if (idade >= 30)
                    aumento = 200;
                else
                    aumento = 150;
            else { 
                MessageBox.Show("Insira M ou F para sexo.");
            return;
            }



            salario2 = salario + aumento;
            txtresultado.Text = salario2.ToString() + " é o novo salário de " + nome;
            
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtidade.Clear();
            txtnome.Clear();
            txtsexo.Clear();    
            txtsalario.Clear();
            txtresultado.Clear();   
            txtnome.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            menu.Show();
            this.Hide();
        }

        private void frmexercicio2_Load(object sender, EventArgs e)
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
