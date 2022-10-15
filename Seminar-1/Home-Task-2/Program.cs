Console.Write("Введите число 1: ");
int Number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int Number_2 = Convert.ToInt32(Console.ReadLine());

if (Number_1 > Number_2)
{
    Console.Write($"Максимальное число = {Number_1}, а минимальное число = {Number_2}");
}
else
{
    Console.Write($"Максимальное число = {Number_2}, а минимальное число = {Number_1}");
}