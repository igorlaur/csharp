using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresMatemáticos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {
           
            int parcela_1 = int.Parse(text_parcela_1.Text);
            int parcela_2 = int.Parse(text_parcela_2.Text);
            //int resultado;

            /// Adição (+)

            //resultado = parcela_1 + parcela_2;

            /// Subtração (-)

            //resultado = parcela_1 - parcela_2;

            /// Multiplicação (*)

            //resultado = parcela_1 * parcela_2;

            /// Divisão (/)

            //resultado = parcela_1 / parcela_2;

            /// Módulos (Resto da divisão) (%)

            //resultado = parcela_1 % parcela_2;

            int resultado = 50;

            //resultado = resultado + 1;
            //resultado++;      // incremento automático
            //resultado += 5    /* resultado = resultado + 5 */

            label_resultado.Text = (++resultado).ToString();// Converter resultado numérico para alfanumérico

        }
    }
}
