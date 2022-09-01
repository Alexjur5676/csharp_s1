// Задайте значения M и N. Напишите программу, которая 
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

if(numberN > numberM)
{
    PrintNumbersMToN(numberM, numberN);    
}
else
{
    Console.WriteLine("Число M должно быть меньше N");
}
PrintNumbersMToN(numberN, numberM);

void PrintNumbersMToN(int n, int m)
{
    if (n < m) return;
    PrintNumbersMToN(n - 1, m);
    Console.Write(n + " ");  
}
