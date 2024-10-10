int num = int.Parse(Console.ReadLine());

for (int power = 0; power <= num; power += 2)
{
    Console.WriteLine(Math.Pow(2, power));
}