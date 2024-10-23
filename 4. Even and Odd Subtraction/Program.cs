int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int sumOdd = 0;
int sumEven = 0;

foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        sumEven += number;
    }
    else
    {
        sumOdd += number;
    }
}

int diff = sumEven - sumOdd;
Console.WriteLine(diff);
