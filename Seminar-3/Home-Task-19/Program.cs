// Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void PrintPalindromeCheck(int number)
{

    int firstNumeral = number / 10000;
    int lastNumeral = number % 10;
    if (firstNumeral == lastNumeral)
    {
        Console.Write("Введённое число является полиндромом");
    }
    else
    {
        int secondNumeral = number % 10000;
        int forthNumeral = (secondNumeral / 10) % 10;
        if (secondNumeral == forthNumeral)
        {
            Console.Write("Введённое число является полиндромом");
        }
        else
        {
          Console.Write("Введённое число НЕ является полиндромом");  
        }
    }
}

if (number > 99999)
{
    Console.Write("Введённое число не является пятизначным!");
}
else
{
  PrintPalindromeCheck(number);  
}
