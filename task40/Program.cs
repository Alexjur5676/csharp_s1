// Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
//  меньше суммы двух других сторон

Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C:");
int c = Convert.ToInt32(Console.ReadLine());
if(a<b+c && b<a+c && c<a+b)
{
    Console.WriteLine("Треугольник существует");
}
else
{
    Console.WriteLine("Треугольник несуществует");
}
