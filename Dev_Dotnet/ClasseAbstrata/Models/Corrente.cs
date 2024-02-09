namespace ClasseAbstrata.Models
{
    internal class Corrente : Conta
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}
