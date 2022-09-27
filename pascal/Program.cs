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
                for (int j = 0; j < matrix.GetLength(1); j++)
            if(matrix[i,j]!=0) Console.Write(matrix[i, j] + " \t");
            else Console.Write(" \t");
        Console.WriteLine();
        Console.WriteLine();
    }
}

// void NewMatrix(int[,] matrix)
// {
//     int k;
//     if (matrix.GetLength(0) % 2 == 0) k = matrix.GetLength(0) / 2-1;
//     else k = (matrix.GetLength(0) + 1)/ 2-1;   

// while(matrix[0,k]!=1)
// {
    
// for (int i = matrix.GetLength(1)-3; i >=0; i--)
// {
//     int count =3;
//     if(matrix[i,matrix.GetLength(0)-2]==0)
//     {
//     for (int j = matrix.GetLength(0)-2; j>0; j--)
//     {   
       
//         int temp =matrix[i, j];        
//         matrix[i, j] = matrix[i, j-1];
//         matrix[i, j-1]=temp;
//         count++; 
//     }
//     }   
// }
// }
// }
int[,] matrix = new int[N, N];
InputMatrix(matrix);
PrintMatrix(matrix);
// NewMatrix(matrix);
