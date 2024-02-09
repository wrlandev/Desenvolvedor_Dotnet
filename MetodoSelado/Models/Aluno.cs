namespace MetodoSelado.Models
{
    internal class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresensar()
        {
            Console.WriteLine($"Olá meu nome e {Nome} eu tenho {Idade} anos e minha nota e de {Nota}");
        }
    }
}
