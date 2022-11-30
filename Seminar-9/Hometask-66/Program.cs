/* Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

void printOutSum(int M, int N, int sum)
{
    sum = sum + N;
    if (N <= M)
    {
        Console.Write($" {sum} ");
        return;
    }
    printOutSum(M, N - 1, sum);
}


Console.Write("Введите значение М: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int temp = M;
if (M > N)
{
    M = N;
    N = temp;
}

Console.Write($"{M}, {N} ->");
printOutSum(M, N, temp = 0);