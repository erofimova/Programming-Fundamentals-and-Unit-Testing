int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

bool ascending = a < b && b < c;
bool descending = a > b && b > c;

if (ascending)
{
    Console.WriteLine("Ascending");
}
else if (descending)
{
    Console.WriteLine("Descending");
}
else  Console.WriteLine("Not sorted"); 