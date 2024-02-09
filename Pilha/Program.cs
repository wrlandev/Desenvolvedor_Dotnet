Stack<int> pilha = new();

pilha.Push(0);
pilha.Push(1);
pilha.Push(2);
pilha.Push(3);
pilha.Push(4);
pilha.Push(5);

pilha.Pop();

foreach (int i in pilha)
{
    Console.WriteLine(i);
}