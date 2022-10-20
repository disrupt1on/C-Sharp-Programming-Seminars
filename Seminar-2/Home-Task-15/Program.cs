Console.WriteLine("Введите цифру дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Этот день является выходным");
    }
    else
    {
    Console.WriteLine("Этот день не является выходным");
    }
}
else
{
    Console.WriteLine("Такого дня недели нет!");
}
