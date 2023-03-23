//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях
void InputArray(int[] array)
{
    for (int i = 0; i< array.Length; i++)
        array[i] = new Random().Next(10, 100);
}

int sum_nechet(int[] array)
{
    int sum = 0;
    for(int i = 0 ; i < array.Length; i++)
    {
        if (i % 2 == 1)
            sum = sum + array[i];
    }
    return sum;
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {sum_nechet(array)}");