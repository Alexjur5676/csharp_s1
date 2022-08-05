Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int courentNumber = -number;
while(courentNumber < number)
{
    Console.Write(courentNumber);
    Console.Write(", ");
    courentNumber++;
}
Console.WriteLine(number);
