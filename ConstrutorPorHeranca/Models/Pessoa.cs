﻿namespace Polimorfismo.Models
{
    internal class Pessoa
    {
        public Pessoa(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresensar()
        {
            Console.WriteLine($"Ola meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}
