using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraForm
{
    public partial class Form1 : Form
    {
        // Variaveis Globais
        bool operadorClicado = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                txbTela.Text = dt.Compute(txbTela.Text, "").ToString();
            }
            catch
            {
                   MessageBox.Show("Erro");
            }
            if (txbTela.Text == "∞")
            {
               btnLimpar.PerformClick();
                MessageBox.Show("Deu erro");
            }

        }
        private void numero_Click(object sender, EventArgs e)
        {
            // Obter o botão que esta chamando esse evento:
            Button botaoClicado = (Button)sender;

            // Adicionar o text do botão clicado no textBox:
            txbTela.Text += botaoClicado.Text;

            //"Abaixar a bandeirinha"
            operadorClicado = false;
        }
        private void operador_Click(object sender, EventArgs e)
        {
            // Verificar se o operador ainda não foi clicado:
            if (operadorClicado == false)
            {
                // Obter o botão que esta chamando esse evento:
                Button botaoClicado = (Button)sender;

                // Adicionar o text do botão clicado no textBox:
                txbTela.Text += botaoClicado.Text;

                // Mudar o operadorClicado para true(Levantar a "bandeirinha"):
                operadorClicado = true;
            }

        }
        
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Limpar a tela:
            txbTela.Text = "";
            //  Voltar o operador clicado para true:
            operadorClicado = true;

        }

    }
}
