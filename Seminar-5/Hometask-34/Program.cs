﻿/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.*/

int GetNumbersQuantity(int[] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            quantity += 1;
        }
    }
    return quantity;
}

Console.Write("Введите число (размер массива): ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = new int[number];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}

int numbersQuantity = GetNumbersQuantity(array);
Console.WriteLine($"Количество чётных чисел в массиве = {numbersQuantity}");