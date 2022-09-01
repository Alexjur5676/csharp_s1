//  Напишите программу, которая на вход принимает
//   два числа A и B, и возводит число А в целую 
//   степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write(PowAToB(numberA, numberB));

int PowAToB(int a, int b)
{
    if (b <= 0) return 1;
    return a * PowAToB(a, b - 1);
}


    
