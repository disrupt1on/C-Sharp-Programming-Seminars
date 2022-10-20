Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int a2 = (number / 10) % 10; // вторая цифра в числе

Console.WriteLine($"Вторая цифра в числе = {a2}");