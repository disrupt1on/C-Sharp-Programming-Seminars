//Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

double GetPointsDistance(int coordX1, int coordY1, int coordZ1, int coordX2, int coordY2, int coordZ2)
{
    double distance = Math.Sqrt(Math.Pow(coordX2 - coordX1, 2) + Math.Pow(coordY2 - coordY1, 2) + Math.Pow(coordZ2 - coordZ1, 2));
    return distance;
}

Console.Write("Введите координату X для точки A: ");
int aX = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y для точки A: ");
int aY = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z для точки A: ");
int aZ = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X для точки B: ");
int bX = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y для точки B: ");
int bY = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Z для точки B: ");
int bZ = Convert.ToInt32(Console.ReadLine());

double distance = GetPointsDistance(aX, aY, aZ, bX, bY, bZ);
Console.Write($"Расстояние между точками = {distance}");
