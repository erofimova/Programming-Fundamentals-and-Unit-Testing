int countNumbers = int.Parse(Console.ReadLine());
int[] numbers = new int[countNumbers];

for (int number = 1; number <= countNumbers; number++)
{
    int value = int.Parse(Console.ReadLine());
    numbers[number - 1] = value;
}

for (int position = numbers.Length - 1; position >= 0; position--)
{
    Console.Write(numbers[position] + " ");
}


