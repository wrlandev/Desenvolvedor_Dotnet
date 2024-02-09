Dictionary<string, string> estados = new();

estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio Janeiro");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("BA");
estados["SP"] = "São Paulo - valor alterado";

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

string chave = "BA";
Console.WriteLine($"Verificando o elemento");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor esxistente {chave}");
}
else
{
    Console.WriteLine($"Valor não existe {chave}");
}