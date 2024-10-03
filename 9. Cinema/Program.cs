string movieType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int seats = int.Parse(Console.ReadLine());

double price = 0;

switch (movieType)
{
    case "Premiere":
        price = 12.00;
        break;
    case "Normal":
        price = 7.50;
        break;
    case "Discount":
        price = 5.00;
        break;
}

double total = rows * seats * price;

Console.WriteLine($"{total:F2}");