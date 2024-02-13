using Calculadora.Services;

CalculadoraImp calc = new CalculadoraImp();

int x = 2;
int y = 2;

Console.WriteLine($"{x} + {y} e igual a {calc.Somar(x , y)}");