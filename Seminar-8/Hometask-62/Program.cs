/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

void fillArraySpirally(int[,] array)
{
    int number = 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[0, j] = number;
        number++;
    }
    for (int i = 1; i < array.GetLength(1); i++)
    {
        array[i, 4 - 1] = number;
        number++;
    }
    for (int k = 4 - 2; k >= 0; k--)
    {
        array[4 - 1, k] = number;
        number++;
    }
    for (int l = 4 - 2; l > 0; l--)
    {
        array[l, 0] = number;
        number++;
    }

    while (number < 4 * 4)
    {
        int x = 1;
        int y = 1;
        while (array[x, y + 1] == 0)
        {
            array[x, y] = number;
            number++;
            y++;
        }

        while (array[x + 1, y] == 0)
        {
            array[x, y] = number;
            number++;
            x++;
        }

        while (array[x, y - 1] == 0)
        {
            array[x, y] = number;
            number++;
            y--;
        }

        while (array[x - 1, y] == 0)
        {
            array[x, y] = number;
            number++;
            x--;
        }
    }


    for (int c = 0; c < 4; c++)
    {
        for (int d = 0; d < 4; d++)
        {
            if (array[c, d] == 0)
            {
                array[c, d] = number;
            }
        }
    }

    for (int p = 0; p < 4; p++)
    {
        for (int r = 0; r < 4; r++)
        {

            Console.Write(array[p, r] + "  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите желаемое количество строк маcсива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите желаемое количество колонок массива (равное количеству строк!): ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
fillArraySpirally(array);


