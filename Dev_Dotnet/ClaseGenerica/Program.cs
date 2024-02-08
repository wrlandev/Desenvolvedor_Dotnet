using ClaseGenerica.Models;

MeuArray<int> arrayInteiro = new();
arrayInteiro.AddElemento(30);
Console.WriteLine(arrayInteiro[0]);

MeuArray<string> arrayString = new();
arrayString.AddElemento("Wrlan");
Console.WriteLine(arrayString[0]);