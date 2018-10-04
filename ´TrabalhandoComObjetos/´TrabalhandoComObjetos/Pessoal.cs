using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _TrabalhandoComObjetos
{
    class Pessoal
    {
        public string nome;
        public double altura;
        
        public void FaleSobreVoce()
        {
            Console.WriteLine("Meu nome é " + this.nome + " e minha altura é " + this.altura + " metros");
        }
    }
}
