using Tuplas.Models;

(int Id, string Nome, string Sobrenome) tupla = (1, "Wrlan", "Silva");
Console.WriteLine(tupla);

LeituraDeArquivo arquivo = new();
var (sucesso, linhas, _) = arquivo.LerArquivo(
    "C:\\" +
    "Dev\\" +
    "Dotnet\\" +
    "Formacoes\\" +
    "Desenvolvedor_Dotnet\\" +
    "Dev_Dotnet\\" +
    "LeituraDeArquivo\\" +
    "Arquivos\\" +
    "ArquivoDeLeitura.txt");

if(sucesso)
{
    //Console.WriteLine("Quantidade de linhas: " + quantidadeDeLinhas);
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
    
}
else
{
    Console.WriteLine("Erro");
}