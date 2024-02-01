using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsandoThrow.Models
{
    internal class Ex
    {
        public void Metodo1()
        {
            Metodo2();
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            try
            {
                Metodo4();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exceção tratada");
            }
           
        }
        public void Metodo4()
        {
            throw new Exception("Erro");
        }
    }
}
