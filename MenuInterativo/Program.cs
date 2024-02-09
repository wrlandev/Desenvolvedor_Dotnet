string opcao;

while(true)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Buscar");
    Console.WriteLine("3 - Apagar");
    Console.WriteLine("4 - Encerrar");

    opcao = Console.ReadLine();

    switch(opcao)
    {
        case "1": Console.WriteLine("Cadastrar");
        break;
        case "2": Console.WriteLine("Buscar");
        break;
        case "3":
        Console.WriteLine("Apagar");
        break;
        case "4":
        Console.WriteLine("Encerrar");
        Environment.Exit(0);
        break;

        default: Console.WriteLine("Opção inválida");
        break;
    }
}