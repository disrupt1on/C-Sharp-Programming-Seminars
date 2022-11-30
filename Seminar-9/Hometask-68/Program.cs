/* Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int searchAkkermanFunction(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return searchAkkermanFunction(M - 1, 1);
    }
    else
    {
        return searchAkkermanFunction(M - 1, searchAkkermanFunction(M, N - 1));
    }
}

Console.Write("Введите неотрицательное значение М: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите неотрицательное значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int akkermanFunction = searchAkkermanFunction(M, N);
Console.Write($"M = {M}, n = {N} - > A(M,N) = {akkermanFunction}");

