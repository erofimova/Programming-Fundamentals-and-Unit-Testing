int number = Math.Abs(int.Parse(Console.ReadLine()));

Console.WriteLine(GetMultipleOfEvenAndOdds(number));

static int GetSumOfEvenDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int lastDigit = num % 10;
        if (lastDigit % 2 == 0)
            sum += lastDigit;
        num /= 10;
    }
    return sum;
}

static int GetSumOfOddDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int lastDigit = num % 10;
        if (lastDigit % 2 != 0)
            sum += lastDigit;
        num /= 10;
    }
    return sum;
}

static int GetMultipleOfEvenAndOdds(int num)
{
    return GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
}