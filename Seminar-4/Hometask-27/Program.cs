//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
//Для решения задания использование цикла for является обязательным условием

int GetNumeralsSum(int number)
{
    int numeral = number % 10;
    int sum = 0;

    for( ; number > 0; )
    {
        sum = sum + numeral;
        number = number / 10;
    }
    return sum;
 }

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = GetNumeralsSum(number);
Console.WriteLine(sum);
