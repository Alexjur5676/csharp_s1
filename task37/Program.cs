﻿// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и 
// предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


// Console.WriteLine("Введите колличество элементов массива:");
// int N = Convert.ToInt32(Console.ReadLine());
int[] array = { 1, 2, 3, 4, 5 };

// int[] array = new int[N];
int[] arrayResult = new int[array.Length / 2 + array.Length % 2];
// Random rand = new Random();
// int res;
int number = array.Length;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-9, 10);
// }

for (int i = 0; i < arrayResult.Length; i++)
{
    arrayResult[i] = array[i] * array[array.Length - 1 - i];
}
if (array.Length %2 != 0)
{
    arrayResult[arrayResult.Length - 1] = array[array.Length/2];
}
    Console.WriteLine(string.Join(", ", arrayResult));