// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 10);
        }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

int CountMatrix(int[,] matrix)
{
    int glob_sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int local_sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            local_sum += matrix[i, j];            
        }
        if (local_sum < glob_sum || glob_sum == 0)
            glob_sum = local_sum;
    }
    return glob_sum;
}


Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
while(size[0] == size[1])
{
    Console.Write("Ошибка. Массив должен быть прямоугольным\nВведите размерность массива: ");
    size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
}
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
Console.Write($"Строка с наименьшей суммой элементов: {CountMatrix(matrix)}");