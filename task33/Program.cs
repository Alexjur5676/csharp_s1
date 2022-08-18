//  Задайте массив. Напишите программу, которая определяет,
//   присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Массивы к задачам 32 и 33 можно сделать рандомными.
//  В задаче 33 на экран выводится ТОЛЬКО одно сообщение: 
//  либо "да", либо "нет".

Console.WriteLine("Введите колличество элементов массива:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число для поиска его в массиве:");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = new int[A];
Random rand = new Random();
int i;
bool flag = false;  

for (i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9, 10);
    if (array[i] == number)
    {
        flag = true;
        // Console.WriteLine($"Да - {number}");
    }
}

Console.WriteLine(string.Join(", ", array));

if (flag == true)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}