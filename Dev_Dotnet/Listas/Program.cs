List<string> lista = new List<string>();

lista.Add("SP");
lista.Add("MG");
lista.Add("RJ");

for(int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"Posição n: {i} - {lista[i]}");
}

//

foreach(string str in lista)
{
    Console.WriteLine(str);
}