int number = int.Parse(Console.ReadLine());

while (true)
{
    if (number >= 0 && number <= 100)
    {
        Console.WriteLine(number);
        break;
    }
    else
    {
        number = int.Parse(Console.ReadLine());

    }
}