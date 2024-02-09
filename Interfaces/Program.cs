using Interfaces.Interfaces;
using Interfaces.Models;

ICalculadora calc = new Calculadora();

Console.WriteLine(calc.Multiplicar(1,2));
Console.WriteLine(calc.Dividir(1, 2));
Console.WriteLine(calc.Somar(1, 2));
Console.WriteLine(calc.Subtrair(1, 2));