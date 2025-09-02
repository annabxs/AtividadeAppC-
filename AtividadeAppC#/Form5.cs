using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeAppC_
{
    public partial class frmexercicio4 : Form
    {
        public frmexercicio4()
        {
            InitializeComponent();
        }

        private void txtitem_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcod_Click(object sender, EventArgs e)
        {

        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {

        }
        double cod, preco;
        string prod, saida;

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            frmmenu menu = new frmmenu();
            menu.Show();
            this.Hide();
        }

        private void frmexercicio4_Load(object sender, EventArgs e)
        {

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcod.Clear();
            txtitem.Clear();
            txtcod.Focus();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            cod = Convert.ToDouble(txtcod.Text);
            switch (cod)
            {
                case 100:
                    preco = 25;
                    prod = "Cachorro Quente";
                    saida = "Produto: " + prod + ", Preço: R$ " + preco;
                    txtitem.Text = saida;
                    break;

                case 101:
                    preco = 15;
                    prod = "Bauru";
                    saida = "Produto: " + prod + ", Preço: R$ " + preco;
                    txtitem.Text = saida;
                    break;

                case 102:
                    preco = 35;
                    prod = "X-burguer";
                    saida = "Produto: " + prod + ", Preço: R$ " + preco;
                    txtitem.Text = saida;
                    break;

                case 103:
                    preco = 47;
                    prod = "Triplo x-burguer";
                    saida = "Produto: " + prod + ", Preço: R$ " + preco;
                    txtitem.Text = saida;
                    break;

                default:
                    MessageBox.Show("Código inválido");
                    break;
            }

        }
    }
}
