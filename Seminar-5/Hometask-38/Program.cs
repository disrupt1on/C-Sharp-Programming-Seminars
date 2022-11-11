/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.*/

double getElementMin(double[] array)
{
    double elementMin = array[0];
    for (int i = 0; i < array.Length; i++ )
    {
        
        if (array[i] < elementMin)
        {
            elementMin = array[i];
        }
    }
    return elementMin;
}

double getElementMax(double[] array)
{
    double elementMax = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > elementMax)
        {
            elementMax = array[i];
        }
    }
    return elementMax;
}

double[] array = new double[arraySize];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble() * 100;
    Console.Write(array[i] + " ");
}

Console.Write("Введите число (размер массива): ");
int arraySize = Convert.ToInt32(Console.ReadLine());

double elementMin = getElementMin(array);
Console.WriteLine($"Минимальный элемент массива = {elementMin}");

double elementMax = getElementMax(array);
Console.WriteLine($"Максимальный элемент массива = {elementMax}");

Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {elementMax - elementMin}");
