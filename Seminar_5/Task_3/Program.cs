// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double find_max(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    result = max - min;
    return result;
}

Console.Clear();

double[] array = {3.03, 7.85, 22.13, 2.05, 78.48};
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным: {find_max(array)}");