// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Console.WriteLine((int)Math.Log2(26) + 1);

// void ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }
// Console.WriteLine("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());
// int size = (int)Math.Log2(number) + 1;
// int[] array = new int[size];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = number % 2;
//     number = number / 2;
// }

// ReverseArray(array);
// Console.WriteLine(string.Join("", array));


// Рекурсия

Console.WriteLine($"Введите десятичное число:");
int number = Convert.ToInt32(Console.ReadLine());

GetBinaryView(number);

void GetBinaryView(int N)
{
    if (N == 0) return;
    GetBinaryView(N/2);
    Console.Write(N%2);
}