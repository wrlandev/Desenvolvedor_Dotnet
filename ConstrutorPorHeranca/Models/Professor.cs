namespace Polimorfismo.Models
{
    internal class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
        }

        public decimal Salario { get; set; }

        public override void Apresensar()
        {
            Console.WriteLine($"Olá meu nome e {Nome} eu tenho {Idade} anos e meu salario e de {Salario}");
        }
    }
}
