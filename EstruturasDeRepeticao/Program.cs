int numero = 5;

for( int num = 0; num <= 10; num++)
{
    Console.WriteLine($"{numero} x {num} = {numero * num}");
}

//

int i = 5;
int con = 0;

while (con <= 10)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
    con++;
}

//

int soma = 0, set = 0;

do
{
    Console.WriteLine("Digite um número (0 para parar!)");
    set = Convert.ToInt32(Console.ReadLine());

    soma += set;

} while (set != 0);

Console.WriteLine($"Total: {soma}");