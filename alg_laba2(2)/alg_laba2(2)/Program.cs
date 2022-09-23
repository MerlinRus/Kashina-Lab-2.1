const int sizeArray = 3;
int[] a = new int[sizeArray];

Random r = new Random();
for (int i = 0; i < sizeArray; ++i)
{
    a[i] = r.Next(-50, 100);
}

Console.WriteLine("Исходный массив:");
for (int i = 0; i < sizeArray; ++i)
{
    Console.WriteLine("\t" + a[i]);
}

int min = a.Min(t => Math.Abs(t));
Console.WriteLine("Минимальный элемент = {0}", min, Math.Abs(min));
