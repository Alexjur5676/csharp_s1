//Напишите программу, которая принимает на вход
//число и проверяет, кратно ли оно одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

int mod = (number % 7 | number % 23);
if (mod == 0)
{
    Console.Write("да ");
}
else
{
    Console.Write("нет ");
}
