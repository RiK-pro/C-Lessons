// Напишите программу, которая заполнит спирально массив 4 на 4.

void InputMatrix(int[,] matrix, int n)
{
    int x = 0, y = 0;
    int dx = 0, dy = 1;
    for (int i = 1; i <= n * n; i++)
    {
        matrix[x, y] = i;
        if (x + dx < 0 || x + dx == n || y + dy < 0 || y + dy == n || matrix[x + dx, y + dy] != 0)
        {
            int temp = dx;
            dx = dy;
            dy = -temp;
        }
        x += dx;
        y += dy;
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j].ToString().PadLeft(2, '0') + "\t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
int n = 4;
int[,] matrix = new int[n, n];
InputMatrix(matrix, n);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
