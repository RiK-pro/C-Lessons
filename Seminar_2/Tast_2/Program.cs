Console.Clear();
int n = new Random().Next(1, 100000);
Console.WriteLine($"Случайное сгенерированное число {n}");
if (n < 100) 
Console.WriteLine("третьей цифры нет");
else 
while (n > 999)
    n /= 10;
Console.WriteLine(n % 10);