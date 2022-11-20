/*Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
Округлите значения, генерируемые Random до двух знаков после запятой.*/

void fillAndPrintOutArray(double [ , ] array, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++ )
        {
            array[i,  j] = Math.Round(new Random().NextDouble() * 100, 2);
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

double [ , ] array = new double [rows, columns];
fillAndPrintOutArray(array, rows, columns);
