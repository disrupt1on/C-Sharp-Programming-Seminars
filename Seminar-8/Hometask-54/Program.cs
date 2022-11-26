/*Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки 
двумерного массива*/

void reverseRowsFromMaxToMinElement (int[ , ] array)
{
    int tempValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)    
        {
            for(int n = 0; n < array.GetLength(1) - 1; n++)
            {
                if(array[i, n] < array[i, n + 1])
                {
                    tempValue = array[i, n + 1];
                    array[i, n + 1] = array [i, n];
                    array[i, n] = tempValue;
                }
            }
        }
    
    }

    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)    
        {
            Console.Write(array[i,  j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите желаемое количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите желаемое количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[ , ] array = new int [rows, columns];
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i,  j] = new Random().Next(100);
        Console.Write(array[i,  j] + " ");
    }
    Console.WriteLine();
}

reverseRowsFromMaxToMinElement(array);