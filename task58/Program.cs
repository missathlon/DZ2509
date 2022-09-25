// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

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
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}

int[,] ReleaseMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] ProductMatrix = new int[matrix1.GetLength(1), matrix2.GetLength(0)];
    for (int i = 0; i < matrix1.GetLength(1); i++)
    {
        for (int j = 0; j < matrix2.GetLength(0); j++)
        {
            ProductMatrix[i,j]=0;

            for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    ProductMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }


        }
    }
    return ProductMatrix;
}

Console.Write("Введите кол-во строк 1 матрицы: ");
int l = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов 1 матрицы (равное количеству строк 2 матрицы): ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] FirstMatrix = new int[l, m];

Console.Write("Введите кол-во стобцов 2 матрицы: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] SecondMatrix = new int[m, n];

InputMatrix(FirstMatrix);
Console.WriteLine("A:");
PrintMatrix(FirstMatrix);
Console.WriteLine();
InputMatrix(SecondMatrix);
Console.WriteLine("B:");
PrintMatrix(SecondMatrix);
Console.WriteLine("C:");

PrintMatrix(ReleaseMatrix(FirstMatrix, SecondMatrix));