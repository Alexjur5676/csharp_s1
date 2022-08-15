// Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (count = 0; number > 0; count++)
{
    number = number / 10;
    //number /+ 10;
}
// while (number > 0)
// {
//     number = number / 10;
//     count ++;
// }
Console.WriteLine(count);