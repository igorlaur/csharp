﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
            // IF
            //int valor = 21;

            //if(valor < 5)
            //{
            //    label_resultado.Text = "Valor < 5";
            //}
            //else if (valor < 10)
            //{
            //    label_resultado.Text = "Valor < 10";
            //}
            //else if (valor < 15)
            //{
            //    label_resultado.Text = "Valor < 15";
            //}
            //else
            //{
            //    label_resultado.Text= "Não deu!";
            //}


            // SWITCH = INTERRUPTOR

            //int valor = 20;

            //switch (valor) // Interruptor
            //{
            //    case 10: // No caso do valor ser 10 
            //        label_resultado.Text = "Primeira opção";
            //        break;

            //    case 20:
            //        label_resultado.Text = "Segunda opção";
            //        break;

            //    default: // Caso não verifique
            //        label_resultado.Text = "Nenhum resultado";
            //        break;
            //}
            //        if(valor == 10)
            //        {

            //        }

            // Operador Ternário
            int valor = 10;

            if(valor == 10)
            {
                label_resultado.Text = "SIM";
            }
            else
            {
                label_resultado.Text = "NÃO";
            }

            label_resultado.Text = valor == 10 ? "SIM" : "NÃO";

            string resultadofinal = valor == 10 ? "Sim SENHOR" : "Não SENHOR";
        }
    }
}
