﻿Console.Clear();
Console.Write("Введите число: ");
string n = Convert.ToString(Console.ReadLine());
int sum = 0;
for (int i = 0; i < n.Length; i++)
{
    sum = sum + Convert.ToInt32(n[i].ToString());
}
Console.WriteLine($"Сумма цифр числа {sum}");