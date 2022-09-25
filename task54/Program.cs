// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] ReleaseMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            int jmax = j;
            for (int k = j + 1; k < matrix.GetLength(0); k++)
            {
                if (matrix[i, k] > matrix[i, jmax]) jmax = k;
            }
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i, jmax];
            matrix[i, jmax] = temp;
        }
    }
    return matrix;
}

Console.Write("Введите кол-во строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов: ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[i, j];
InputMatrix(matrix);
PrintMatrix(matrix);
PrintMatrix(ReleaseMatrix(matrix));