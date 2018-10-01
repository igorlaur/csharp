using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeiraAplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            /* Region serve para eu esconder meu código */
            #region região com nome alterado

            // Numéricas

            //byte = 0 to 255
            byte idade = 45;

            //short = -32,768 to 32,767
            short idade2 = 45;

            //int = -2.147.483.648 to -2.147.483.648
            int idade_planeta = 234982347;

            //long = -9.223.372.036.854.775.808 to -9.223.372.036.854.775.808
            long valor_enorme = 3245683746354;


            //COM CASAS DECIMAIS

            float valor1 = 10.5f;
            double valor2 = 20.3;
            decimal valor3 = 30.7m;

            caixa_texto.Text = valor3.ToString();

            /*string resultado = "Igor Laur";
            int numero_caracteres = resultado.Length;
            caixa_texto.Text = "Nº caracteres = " + numero_caracteres;*/

            // ALFANUMERICAS 
            /*
            string resultado = "Igor Laur";
            char caracter = '1';
            caixa_texto.Text = caracter.ToString();
            */
            #endregion
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_prosseguir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_clique_Click(object sender, EventArgs e)
        {
            // criar variável - tipo
            #region Região 
            string nome = "Igor Laur";
            int idade = 20;
            int segunda_idade = 22;

            int idade_total = idade + segunda_idade;

            caixa_clique.Text = "Me chamo " + nome + " e tenho " + idade.ToString() + " anos. Meu amigo tem " +
                segunda_idade + " a somatória de nossas idades = " + idade_total;
            #endregion

        }
    }
}
