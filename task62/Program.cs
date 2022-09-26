// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();


void InputMatrix(int[,] matrix)
{
    int a = 1;
    int time = 0;
    while (a <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        for (int j = time; j < matrix.GetLength(0) - time; j++)
        {
            matrix[time, j] = a;
            a++;
        }

        for (int i = time + 1; i < matrix.GetLength(1) - time; i++)
        {
            matrix[i, matrix.GetLength(0) - time - 1] = a;
            a++;
        }

        for (int n = matrix.GetLength(1) - 2 - time; n >= time; n--)
        {
            matrix[matrix.GetLength(1) - 1 - time, n] = a;
            a++;
        }
        for (int m = matrix.GetLength(1) - 2 - time; m > time; m--)
        {
            matrix[m, time] = a;
            a++;
        }
        time++;
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

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во стобцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
