//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//Заполнение массива производит пользователь.

Console.Write("Введите желаемое количество строк: ");
int rowsCount = Convert.ToInt32(Console.ReadLine());

string[] array = new string[rowsCount];
for (int i = 0; i < rowsCount; i++)
{
    Console.Write($"Введите элемент для строки №{i}: ", i + 1);
    array[i] = Console.ReadLine();
}

for (int index = 0; index < array.Length - 1; index++)
{
    Console.Write(array[index] + ", ");
}
Console.Write(array[array.Length - 1]);
