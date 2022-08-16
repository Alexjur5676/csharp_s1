// Напишите программу, которая принимает
//  на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120
Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
int fact = 1;
int i;
if (N >= 1)
{
    for (i = 1; i <= N; i++)
    {
       fact = i * fact;
    }

    Console.WriteLine(fact);
}
else
{
    Console.WriteLine("Введено некорректное число N ");
}