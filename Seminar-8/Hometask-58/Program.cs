/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

Console.Write("Введите желаемое количество строк матрицы 1: ");
int rows1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите желаемое количество колонок матрицы 1: ");
int columns1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите желаемое количество строк матрицы 2: ");
int rows2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите желаемое количество колонок матрицы 2: ");
int columns2 = Convert.ToInt32(Console.ReadLine());

int[ , ] matrix1 = new int[rows1, columns1];

for(int i = 0; i < matrix1.GetLength(0); i++)
{
    for(int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i,  j] = new Random().Next(10);
        Console.Write(matrix1[i,  j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[ , ] matrix2 = new int[rows2, columns2];
for(int i = 0; i < matrix2.GetLength(0); i++)
{
    for(int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i,  j] = new Random().Next(10);
        Console.Write(matrix2[i,  j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Нельзя перемножить. Количество столбцов матрицы 1 должно равняться количеству строк матрицы 2!");
}

int[ , ] matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
for (int i = 0; i < matrix1.GetLength(0) - 1; i++)
{
    for (int j = 0; j < matrix2.GetLength(1) - 1; j++)
    {
        matrix3[i, j] = 0;
        for (int n = 0; n < matrix1.GetLength(1) - 1; n++)
        {
            matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
            
        }
    }   Console.WriteLine(matrix3);
}

