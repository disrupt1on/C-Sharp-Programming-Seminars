Console.Write("Введите число N: ");
int Number_N = Convert.ToInt32(Console.ReadLine());

int i = 1;
while (i <= Number_N)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
    i = i + 1;
}