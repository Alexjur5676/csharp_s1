// Не используя рекурсию, выведите первые N чисел Фибоначчи.
//  Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// 1 способ
Console.WriteLine($"Введите число N:");
int number = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[number];
Array[0]=0;
Array[1] =1;
for (int i = 2; i < Array.Length; i++)
{
    Array[i]=Array[i-1]+Array[i-2];
}
Console.WriteLine(string.Join(" ", Array));

// 2 способ

// Console.WriteLine($"Введите число n:");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] Fibonacci(0);

// // 3 способ не верно

// Console.WriteLine($"Введите число N:");
// // int number = Convert.ToInt32(Console.ReadLine());
// int Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }
// for (int i = 0; i < 5; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }