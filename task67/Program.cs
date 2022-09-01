//  Напишите программу, которая будет принимать
//  на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int GetSumDigit(int number);
{
    if(number <= 0) return 0;
    return number % 10 + GetSumDigit(number / 10);
}

void PrintNumbersToN(int n)
{
    if(n < 1) return;
    PrintNumbersToN(n - 1);
    Console.Write(n + " ");
}
int res = GetSumDigit(number / 10);
