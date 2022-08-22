// Напишите программу, которая будет создавать копию
//  заданного массива с помощью поэлементного копирования.

int [] array = {24,62,5,19,4};
int [] newArray = new int [array.Length];

for (int i = 0; i < array.Length; i++)
{
    newArray[i] = array [i];
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine(string.Join(",", newArray));