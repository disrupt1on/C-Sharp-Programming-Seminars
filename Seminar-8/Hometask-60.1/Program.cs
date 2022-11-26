/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

void printOutArray(int[,,] array3D)
{
    int[] array = new int[2 * 2 * 2];
    array[0] = new Random().Next(10, 100);

    for (int i = 1; i < array.Length; i++)
    {
        array[i] = new Random().Next(10, 100);

        for (int j = 0; j <= i - 1; j++)
        {
            if (array[i] == array[j])
            {
                array[i] = new Random().Next(100);
                j = 0;
            }
        }
    }

    int k = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int n = 0; n < array3D.GetLength(2); n++)
            {
                while (array3D[i, j, n] == 0)
                {
                    array3D[i, j, n] = array[k];
                    k++;
                }
                Console.Write($"{array3D[i, j, n]} ({i}, {j}, {n})" + " ");
            }
        }
        Console.WriteLine();
    }
    
}

int[,,] array3D = new int[2, 2, 2];
printOutArray(array3D);

