// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int[] a = new int[8];
for (int i = 0; i < a.Length; i++)
    a[i] = new Random().Next(0, 100);
Console.WriteLine($"[{string.Join(", ", a)}]");