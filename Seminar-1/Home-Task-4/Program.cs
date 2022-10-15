Console.Write("Введите число 1: ");
int Number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int Number_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int Number_3 = Convert.ToInt32(Console.ReadLine());
int Number_Max = 0;


if (Number_1 > Number_2)
{
    Number_Max = Number_1;
}
else
{
    Number_Max = Number_2;
}

if (Number_3 > Number_Max)
{
    Number_Max = Number_3;
    Console.Write($"Максимальное число = {Number_Max}");
}
else
{
    Console.WriteLine($"Максимальное число = {Number_Max}");
}
