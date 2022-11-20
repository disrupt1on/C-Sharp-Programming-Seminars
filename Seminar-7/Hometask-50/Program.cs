/* Напишите программу, которая будет принимать от пользователя 
позицию (M, N) двумерного массива и возвращать значение элемента, 
стоящего в этой позиции. Если такой позиции в массиве нет, 
то сообщить об этом пользователю. 
Сгенерировать массив случайным образом. Размерность массива определить 
самостоятельно. Использование методов для заполнения массива обязательно. 
Остальное можно реализовать в главной программе.*/

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

int searchRequestedElement(int[ , ] array, int row, int column)
{
    int requestedElement = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <array.GetLength(1); j++ )
        {
            if (i == row && j == column)
            {
                requestedElement = array[i, j];
            }
            }
    } 
    return requestedElement;
}    
    
Console.Write("Введите желаемую строку: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите желаемую колонку: ");
int column = Convert.ToInt32(Console.ReadLine());

int [ , ] array = new int [5, 6];
fillArray(array);

int requestedElement = searchRequestedElement(array, row, column);
if (row > array.GetLength(0) || column > array.GetLength(1))
{
    Console.Write("Такого элемента не существует. Попробуйте с другими вводными данными.");
}
else
{
    Console.Write($"Запрашиваемый элмент - {requestedElement}");
}

