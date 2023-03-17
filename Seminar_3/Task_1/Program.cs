// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();
Console.Write("Введите пятизначное число: ");
string x = Convert.ToString(Console.ReadLine()!);
while (x.Length < 5 || x.Length > 5)
{
    Console.WriteLine("Вы ошиблись! Введеное число не пятизначное");
    Console.Write("Введите число ещё раз: ");
    x = Convert.ToString(Console.ReadLine()!);
}
if (x[0] != x[4])
    Console.WriteLine($"Число {x} не является палиндромом");
else if (x[1] != x[3])
    Console.WriteLine($"Число {x} не является палиндромом");
else
    Console.WriteLine($"Число {x} является палиндромом");