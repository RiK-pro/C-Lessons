//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] InputArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i< array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;      
}

int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count += 1;
    }
    return count;
}

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = int.Parse(Console.ReadLine());
int[] array = InputArray(n);
Console.Write("Кол-во элементов больше 0: ");
Console.Write(Count(array));