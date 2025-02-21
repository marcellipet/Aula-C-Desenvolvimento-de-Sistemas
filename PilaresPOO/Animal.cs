using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresPOO
{
    public class Animal
    {
        public string nome;
        public int idade;
        public string tipoAlimentacao;

        public void emitirSom()
        {
            Console.WriteLine($"{nome} está emitindo um som...");
        }

    }
}
