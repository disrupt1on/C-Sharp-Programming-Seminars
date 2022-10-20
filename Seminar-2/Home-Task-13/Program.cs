Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a3 = number % 10; // третья цифра в числах < 1000
int a3_1 = (number / 100) % 10; // третья цифра в числах > 1000

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
  if (number < 1000)
  {
    Console.WriteLine(a3);
  }
  else
  {
    Console.WriteLine(a3_1);
  }
}
