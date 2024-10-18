int num = int.Parse(Console.ReadLine());
PrintNumType(num);

static void PrintNumType(int num)
{
    if (num > 0)
    {
        Console.WriteLine($"The number {num} is positive.");
    }
    else if (num < 0)
    {
        Console.WriteLine($"The number {num} is negative.");
    }
    else
    {

        Console.WriteLine($"The number {num} is zero.");
    }
}