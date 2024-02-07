using Deserializacao.Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("C:\\Dev\\Dotnet\\Formacoes\\Desenvolvedor_Dotnet\\Dev_Dotnet\\Serializacao\\Vendas\\vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach(Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id} Produto: {venda.Produto} Preço: {venda.Preco}");
}