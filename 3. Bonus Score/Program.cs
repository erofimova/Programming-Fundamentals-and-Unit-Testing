int points = int.Parse(Console.ReadLine());
int result;

if (points >= 0 && points <= 3)
{
    result = points + 5;
    Console.WriteLine(result);
}
else if (points >= 4 && points <= 6)
{
    result = points + 15;
    Console.WriteLine(result);
}
else if (points >= 7 && points <= 9)
{
    result = points + 20;
    Console.WriteLine(result);
}