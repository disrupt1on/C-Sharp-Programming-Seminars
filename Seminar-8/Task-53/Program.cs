/* Задайте двумерный массив. 
Напишите программу, которая поменяет местами первую и последнюю строку.*/

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

void changeRows(int [ , ] array)
{
    int tempValue;
    for (int j = 0; j <array.GetLength(1); j++ )
    {
        tempValue = array[0, j];
        array[0, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = tempValue;
        
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

changeRows(array);