namespace MetodoSelado.Models
{
    internal class Professor : Pessoa
    {
        public decimal Salario { get; set; }

        public sealed override void Apresensar()
        {
            Console.WriteLine($"Olá meu nome e {Nome} eu tenho {Idade} anos e meu salario e de {Salario}");
        }
    }
}
