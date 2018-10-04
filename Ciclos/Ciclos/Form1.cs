using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            //lista.Items.Add(1);
            //lista.Items.Add(2);

            // FOR
            //for (int valor = 0; valor <= 50; valor+=2)
            //{
            //    lista.Items.Add(valor);
            //}

            //WHILE
            //int vezes = 0;
            //while (vezes <= 100)
            //{
            //    lista.Items.Add(vezes);
            //    vezes++;
            //}

            //DO
            //int vezes = 0;
            //do
            //{
            //    lista.Items.Add(vezes);
            //    vezes++;
            //} while (vezes <= 100);


            // FOREACH

            //string frase = "Este ciclo é fantástico";

            //lista.Items.Add(frase);
            //lista.Items.Add(frase.ToUpper()); // Letra maiúscula
            //lista.Items.Add(frase.Length); // Comprimento

            List<string> lista_nomes = new List<string>
            {
                "Joao", "Antonio", "Igor", "Neide", "Patricia"
            };

            foreach(string s in lista_nomes) // Por cada
            {
                lista.Items.Add(s);
            }
        }
    }
    }
