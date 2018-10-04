using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TrabalhandoComObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            String entrada = "";
            Pessoal pessoa1;
            Carro carro1;
            pessoa1 = new Pessoal();
            carro1 = new Carro();

            Console.Write("Informe o seu nome: ");
            entrada = Console.ReadLine(); // Guardamos nome que usuário inseriu
            pessoa1.nome = entrada; // Armazenamos o valor q o usuário informou

            Console.Write("Informe a sua altura: ");
            entrada = Console.ReadLine(); // Guardamos nome que usuário inseriu
            pessoa1.altura = Convert.ToDouble(entrada); // Armazenamos o valor q o usuário informou

            pessoa1.FaleSobreVoce();
            Console.ReadKey();

            Console.Write("Qual o seu carro? ");
            entrada = Console.ReadLine();
            carro1.carro = entrada;
            carro1.carroUsuario();
            Console.ReadKey();


        }
    }
}
