int[] arrayInteiros = new int[3];

arrayInteiros[0] = 10;
arrayInteiros[1] = 20;
arrayInteiros[2] = 30;

Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

for (int i = 0; i < arrayInteiros.Length; i++)
{
    Console.WriteLine($"Posição n: {i} - {arrayInteiros[i]}");
}

//

foreach(int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}