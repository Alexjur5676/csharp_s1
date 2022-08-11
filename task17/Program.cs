// Напишите программу, которая принимает
//  на вход координаты точки (X и Y),
//   причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//  в которой находится эта точка.
Console.WriteLine("Введите координату по X");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату по Y");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine(" Точка находится в первой координатной четверти");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Точка находится в второй координатной четверти");
}
else if (X < 0 && Y < 0)
{
    Console.WriteLine(" Точка находится в третьей координатной четверти");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine(" Точка находится в четвертой координатной четверти");
}
else 
{
    Console.WriteLine(" Мы не можем определить координатную площадь");
}
