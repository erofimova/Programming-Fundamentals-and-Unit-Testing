
int number = int.Parse(Console.ReadLine());
int result = 1;
for (int i = 1; i <= 10; i++)
{
    result = number * i;
    Console.WriteLine($"{number} x {i} = {result}");
}
