int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int sum = 0;

foreach (int number in numbers)
{
    sum += number;
}
Console.WriteLine(sum);