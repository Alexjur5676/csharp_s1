// Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние
//  между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


Console.WriteLine("Введите координату по x первой точки");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по y первой точки");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по x второй точки");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по y второй точки");
double y2 = Convert.ToInt32(Console.ReadLine());

// √(xb - xa)2 + (yb - ya)2

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine($"{result:f3}");