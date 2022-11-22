/* Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.*/

void fillArray(int [ , ] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++ )
        {
            array[i,  j] = new Random().Next(100);
            Console.Write(array[i,  j] + " ");
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

void changeRowsToColumns(int [ , ] array)
{
    for (int i = 0; i <array.GetLength(0); i++ )
    {
        for (int j =  i; j < array.GetLength(1); j++)
        { 
            (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
        }
    }
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите желаемое количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите желаемое количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[ , ] array = new int [rows, columns];
fillArray(array);

Console.WriteLine();

changeRowsToColumns(array);