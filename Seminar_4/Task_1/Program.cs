// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
Console.Clear();
Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < b; i++)
    result = result * a;   
Console.WriteLine(result);