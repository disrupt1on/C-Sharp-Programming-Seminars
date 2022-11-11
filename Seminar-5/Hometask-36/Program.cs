/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.*/

int GetElementsSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

Console.Write("Введите число (размер массива): ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите начало числового диапазона: ");
int numberAreaStart = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите конец числового диапазона (число должно быть > начального): ");
int numberAreaEnd = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(numberAreaStart, numberAreaEnd);
    Console.Write(array[i] + " ");
}

int ElementsSum = GetElementsSum(array);
Console.Write($"Сумма элементов, стоящих на нечётных позициях = {ElementsSum}");