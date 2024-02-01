Dictionary<string, string> estados = new();

estados.Add("SP", "São Paulo");
estados.Add("RJ", "Rio Janeiro");
estados.Add("MG", "Minas Gerais");
estados.Add("BA", "Bahia");

foreach (KeyValuePair<string, string> item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

