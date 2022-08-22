// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и 
// предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


Console.WriteLine("Введите колличество элементов массива:");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];

Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
}

// int[] array = { 1, 2, 3, 4, 5 };

int[] resArray = new int[(array.Length + 1) / 2];

for (int i = 0; i < resArray.Length; i++)
{
    resArray[i] = array[i] * array[array.Length - 1 - i];
}
Console.WriteLine(string.Join(", ", array));

if (array.Length % 2 == 1)
{
    resArray[resArray.Length - 1] = array[array.Length / 2];
}
Console.WriteLine(string.Join(", ", resArray));