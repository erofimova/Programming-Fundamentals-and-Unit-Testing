int count = int.Parse(Console.ReadLine());
double sum = 0;

for (int num = 1; num <= count; num++)
{
    double value = double.Parse(Console.ReadLine());
    sum = sum + value;
}
Console.WriteLine(sum);