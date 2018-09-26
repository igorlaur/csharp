using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuBlocoDeNotas
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void SalvarClick(object sender, EventArgs e)
        {
           saveFileDialog1.ShowDialog(); // Botão salvar passa funcionar, escolho onde vou salvar.
        }

        private void SalvarOk(object sender, CancelEventArgs e)
        {
            string Caminho = saveFileDialog1.FileName; // Dentro do FileName vai conter o caminho do diretório + nome do arquivo + extensão dele
            File.WriteAllText(Caminho, txbJanela.Text); // Escrever todos os textos. txbJanela é onde escreve
        }
    }
}
