﻿namespace ConstrutorPorHeranca.Models
{
    internal class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
        }

        public double Nota { get; set; }

        public override void Apresensar()
        {
            Console.WriteLine($"Olá meu nome e {Nome} eu tenho {Idade} anos e minha nota e de {Nota}");
        }
    }
}
