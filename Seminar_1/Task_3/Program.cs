Console.Write("Проверка числа на четность. Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 0) Console.WriteLine("0 не является четным числом");
else if (a % 2 == 0)
    Console.WriteLine($"{a} является четным числом");
else Console.WriteLine($"{a} не является четным числом");