


int[] RandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

int[] sourseArray = RandomArray(12,-10,10);
int[] copieArray = sourseArray;
Console.WriteLine($"Исходный массив {string.Join(", ", sourseArray)}");
Console.WriteLine($"Скопированный массив {string.Join(", ", copieArray)}");