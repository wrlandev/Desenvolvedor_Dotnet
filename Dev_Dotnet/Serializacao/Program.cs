using Serializacao.Models;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;
List<Venda> listaVendas = new();

Venda d1 = new(1, "Material", 25.00M , dataAtual);
Venda d2 = new(1, "Software", 2331.00M, dataAtual);
Venda d3 = new(1, "Hardware", 254.00M, dataAtual);
Venda d4 = new(1, "PC", 252.00M, dataAtual);

listaVendas.Add(d1);
listaVendas.Add(d2);
listaVendas.Add(d3);
listaVendas.Add(d4);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("C:\\Dev\\Dotnet\\Formacoes\\Desenvolvedor_Dotnet\\Dev_Dotnet\\Serializacao\\Vendas\\vendas.json", serializado);

Console.WriteLine(serializado);