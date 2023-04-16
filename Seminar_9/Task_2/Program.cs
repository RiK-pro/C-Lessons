//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int f(int a, int b)
{
    if (a == b)
        return a;
    return f(a + 1, b) + a;
}

Console.Clear();
Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(m, n));

