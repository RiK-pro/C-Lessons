// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);
    int[,] result = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            int sum = 0;
            for (int k = 0; k < cols1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}


Console.Clear();
int[,] matrix1 = {{2, 4}, {3, 4}};
int[,] matrix2 = {{3, 2}, {3, 3}};


Console.WriteLine("Начальная матрица 1:");
PrintMatrix(matrix1);
Console.WriteLine("Начальная матрица 2:");
PrintMatrix(matrix2);
int[,] result = MultMatrix(matrix1, matrix2);
Console.WriteLine("Результирующая матрица:");
PrintMatrix(result);