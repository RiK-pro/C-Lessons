Console.Clear();
int n = new Random().Next(100, 1000);
Console.WriteLine($"Случайное сгенерированное число {n}");
int n2 = n / 10 % 10;
Console.WriteLine(n2);