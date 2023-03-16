Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n > 0 && n > 5 && n <= 7)
    Console.WriteLine("yes");
else
    Console.WriteLine("no");