int num = int.Parse(Console.ReadLine());
int power = int.Parse(Console.ReadLine());

PrintPower(num, power);
static void PrintPower(int num, int power)
{
    Console.WriteLine(Math.Pow(num, power));
}
