// See https://aka.ms/new-console-template for more information
Console.Write("Введите число, ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число, ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число, ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число, ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = (k2 * x) + b2;
Console.WriteLine($"две прямые пересекутся в точке c координатами X: {x}, Y: {y}");