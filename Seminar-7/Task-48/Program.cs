/* Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле Amn = m + n*/

Console.Write("Введите желаемое количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите желаемое количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [ , ] array = new int [rows, columns];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++ )
    {
            array[i,  j] = i + j;
            Console.Write(array[i,  j] + " ");
    }
    Console.WriteLine();
}

//array.Length - количество элементов внутри массива
//array.GetLength - возвращает целое число элементов в определённом измерении
