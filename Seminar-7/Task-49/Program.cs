/* Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты*/

void newArray(int[ , ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++ )
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
                Console.Write(array[i,  j] + " ");
            }
            else
            {
                Console.Write(array[i,  j] + " ");
            }
        }
        Console.WriteLine();
    }
}

Console.Write("Введите желаемое количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите желаемое количество колонок: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [ , ] array = new int [rows, columns];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++ )
    {
            array[i,  j] = new Random().Next(1, 10);
            Console.Write(array[i,  j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(" ");

newArray(array);