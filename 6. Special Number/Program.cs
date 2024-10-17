int num = int.Parse(Console.ReadLine());

int token = num;
bool isSpecial = true;

while (token > 0)
{
    int lastDigit = token % 10;

    token /= 10;

    if (num % lastDigit != 0)
    {
        isSpecial = false;
        break;
    }
}

if (isSpecial)
{
    Console.WriteLine($"{num} is special");
}
else
{
    Console.WriteLine($"{num} is not special");
}