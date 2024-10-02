int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());
int thirdNum = int.Parse(Console.ReadLine());

if (firstNum > secondNum)
{
    if (firstNum > thirdNum)
    {
        Console.WriteLine($"{firstNum}");
    }
    else { Console.WriteLine($"{thirdNum}"); }
}
else if (secondNum > thirdNum)
{
    Console.WriteLine($"{secondNum}");
}
else { Console.WriteLine($"{thirdNum}"); }
