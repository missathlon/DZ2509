// (Треугольник Паскаля)
// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.Clear();
Console.Write("Введите кол-во строк: ");
int N = Convert.ToInt32(Console.ReadLine());

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        matrix[i, 0] = 1;
        matrix[i, i] = 1;
    }

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j <= i; j++)
            matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j];
    }
}

void PrintMatrix(int[,] matrix)
{
    
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int k=0;k<=matrix.Length-i;k++)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j < matrix.GetLength(1); j++)
            if(matrix[i,j]!=0) Console.Write(matrix[i, j] + "  ");
            else Console.Write("   ");
        Console.WriteLine();
        Console.WriteLine();
    }
}

int[,] matrix = new int[N,N];
InputMatrix(matrix);
PrintMatrix(matrix);

