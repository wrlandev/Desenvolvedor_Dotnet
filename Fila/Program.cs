using System.Collections;

Queue<int> fila = new();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);
fila.Enqueue(5);

fila.Dequeue();

foreach(int i in fila)
{
    Console.WriteLine(i);
}