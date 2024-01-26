int estoque = 10;
int compra = 5;
bool possivelVenda = estoque >= compra;

Console.WriteLine($"Quantidade em estoque: {estoque}");
Console.WriteLine($"Quantidade de compra: {compra}");
Console.WriteLine($"É possível realizar a venda?: {possivelVenda}");


if (possivelVenda)
{
    Console.WriteLine("Venda realizada");
}
else
{
    Console.WriteLine("Desculpe. não temos a quantidade desejada!");
}

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "i":
    case "e":
    case "o":
    case "u":
        Console.WriteLine("Vogal!");
        break;

    default: Console.WriteLine("Não e uma vogal.");
        break;
}