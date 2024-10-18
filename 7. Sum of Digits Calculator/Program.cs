string input = Console.ReadLine();

while (input != "End")
{
    int token = int.Parse(input);
    int sum = 0;
    for (int i = 0; i < input.Length; i++)
    {
        int digit = token % 10;
        sum += digit;
        token /= 10;

    }
    Console.WriteLine($"Sum of digits = {sum}");
    input = Console.ReadLine();
}
Console.WriteLine("Goodbye");