using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrata.Models
{
    internal abstract class Conta
    {
        protected decimal saldo;

        public abstract void Creditar(decimal valor);
        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo é: {saldo}");
        }
    }
}
