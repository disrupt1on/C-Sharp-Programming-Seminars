/* Пользователь вводит с клавиатуры М чисел. 
Посчитайте, сколько чисел > 0 ввёл пользователь*/

Console.Write("Введите желаемое количество чисел: ");
int numbersQuantity = Convert.ToInt32(Console.ReadLine());

int[] array = new int [numbersQuantity];
for (int i = 0; i < numbersQuantity; i++)
{
        Console.Write($"Введите элемент для числа №{i}: ", i + 1);
        array[i] = Convert.ToInt32(Console.ReadLine());
}

int positiveNumbersCount = 0;
for (int i = 0; i < numbersQuantity; i++)
{
    if (array[i] > 0)
    {
        positiveNumbersCount +=1;
    }
}

Console.Write($"Количество чисел > 0 =  {positiveNumbersCount}");
