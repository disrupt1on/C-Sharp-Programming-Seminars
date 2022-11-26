/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/

Console.Write("Введите желаемое количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите желаемое количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[ , ] array = new int[rows, columns];
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i,  j] = new Random().Next(100);
        Console.Write(array[i,  j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int minSum = 0;
int rowWithMinSum = 0;
for (int i = 0; i <= array.GetLength(1) - 1; i++)
{
    int sum = 0;
    for (int j = 0; j <= array.GetLength(0) - 1; j++ )
    {
        sum += array[j, i];
        
        if(minSum > sum)
        {
            minSum = sum;
            rowWithMinSum = i;
        }
    }
}
Console.WriteLine($"Строка {rowWithMinSum}, сумма {minSum}");