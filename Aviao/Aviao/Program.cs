using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviao
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada = "";
            Aviao aviao1;
            aviao1 = new Aviao();
            Console.WriteLine("Informe a quantidade de turbinas: ");
            entrada = Console.ReadLine();
            aviao1.turbina = Convert.ToInt16(entrada);

            aviao1.usuarioAviao();
            Console.ReadKey();
        }
    }
}
