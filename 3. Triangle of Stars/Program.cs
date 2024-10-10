int size = int.Parse(Console.ReadLine());

for (int row = 1; row <= size; row++)
{
    for (int star = 1; star <= row; star++)
    {
        Console.Write('*');
    }
    Console.WriteLine();
}