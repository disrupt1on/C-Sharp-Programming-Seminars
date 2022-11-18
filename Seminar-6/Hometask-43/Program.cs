/* Напишите программу, которая найдёт точку пересеченя двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, и k2 задаются пользователем*/

void crossCoordsPointSearch (double k1, double b1, double k2, double b2)
{
    double x = 0;
    double y = 0;
    x = (b1 - b2) / (k1 - k2);
    y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

    Console.Write($"Координата точки пересечения двух прямых = {x} ; {y}");
}

Console.Write("Введите координату k1 для первой прямой: ");
double k1= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату b1 для первой прямой: ");
double b1= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату k2 для второй прямой: ");
double k2= Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату b2 для второй прямой: ");
double b2= Convert.ToInt32(Console.ReadLine());

crossCoordsPointSearch(k1, b1, k2, b2);