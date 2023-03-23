void InputArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
        array[i] = new Random().Next(1, 32);
}

string yes_or_no(int[] array)
{
    int three = 0;
    int four = 0;
    for(int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0)
        four ++;
    else 
    three++;  
    }
    if (four >= three)
        return "YES";
    return "NO";
}

Console.Clear();
Console.Write("Первая строка: ");
int n = int.Parse(Console.ReadLine()!);
while (n < 1 || n > 100)
{
    Console.Write("Вы ввели неверное кол-во элементов!\nВведите ещё раз: ");
    n = int.Parse(Console.ReadLine());
}
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Вторая строка: {string.Join(" ", array)}");
Console.WriteLine($"Третья строка: {yes_or_no(array)}");