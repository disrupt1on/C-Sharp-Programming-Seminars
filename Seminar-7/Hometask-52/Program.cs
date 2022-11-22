/*Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для поиска ср. арифметического значения каждого столбца*/

void searchAverage(int [ , ] array)
{
    double sum = 0;
    for (int i = 0; i <= array.GetLength(1) - 1; i++)
    {
        for (int j = 0; j <= array.GetLength(0) - 1; j++ )
        {
           sum = sum + array[j, i];
        }
        Console.Write(Math.Round((sum / array.GetLength(0)), 1) + " ");
        sum = 0;
    }
    
}

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

Console.Write("Введите желаемое количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите желаемое количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [ , ] array = new int [rows, columns];
fillArray(array);

searchAverage(array);