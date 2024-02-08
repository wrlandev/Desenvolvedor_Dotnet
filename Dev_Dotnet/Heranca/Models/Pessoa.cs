using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Models
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void Apresensar()
        {
            Console.WriteLine($"Ola meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}
