try
{
    string[] linahs = File.ReadAllLines("Arquivos\\ArquivoDeLeitura.txt");

    foreach (string linha in linahs)
    {
        Console.WriteLine(linha);
    }
}
catch(Exception ex)
{
    Console.WriteLine($"Erro genérico {ex.Message}");
}
finally
{
    Console.WriteLine("Sucesso");
}