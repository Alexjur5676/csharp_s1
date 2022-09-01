//  Напишите программу, которая будет принимать
//  на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

int sum = GetSumDigit(number);
Console.WriteLine(sum);
int GetSumDigit(int n)
{
    if (n <= 0) return 0;
    return n % 10 + GetSumDigit(n / 10);
}