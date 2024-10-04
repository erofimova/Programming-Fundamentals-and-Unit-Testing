string season = Console.ReadLine();
string accommodationType = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
double pricePerNight = 0;
double totalPrice = 0;
double priceWithDiscount = 0;

switch (season)
{
    case "Spring":
        if (accommodationType == "Hotel")
        {
            pricePerNight = 30;
            totalPrice = pricePerNight * days;
            priceWithDiscount = totalPrice * 0.8;
            Console.WriteLine($"{priceWithDiscount:F2}");
        }
        else if (accommodationType == "Camping")
        {
            pricePerNight = 10;
            totalPrice = pricePerNight * days;
            priceWithDiscount = totalPrice * 0.8;
            Console.WriteLine($"{priceWithDiscount:F2}");
        }
        break;
    case "Summer":
        if (accommodationType == "Hotel")
        {
            pricePerNight = 50;
            totalPrice = pricePerNight * days;
            priceWithDiscount = totalPrice * 1;
            Console.WriteLine($"{priceWithDiscount:F2}");
        }
        else if (accommodationType == "Camping")
        {
            pricePerNight = 30;
            totalPrice = pricePerNight * days;
            priceWithDiscount = totalPrice * 1;
            Console.WriteLine($"{priceWithDiscount:F2}");
        }
        break;
    case "Autumn":
        if (accommodationType == "Hotel")
        {
            pricePerNight = 20;
            totalPrice = pricePerNight * days;
            priceWithDiscount = totalPrice * 0.7;
            Console.WriteLine($"{priceWithDiscount:F2}");
        }
        else if (accommodationType == "Camping")
        {
            pricePerNight = 15;
            totalPrice = pricePerNight * days;
            priceWithDiscount = totalPrice * 0.7;
            Console.WriteLine($"{priceWithDiscount:F2}");
        }
        break;
    case "Winter":
        if (accommodationType == "Hotel")
        {
            pricePerNight = 40;
            totalPrice = pricePerNight * days;
            priceWithDiscount = totalPrice * 0.9;
            Console.WriteLine($"{priceWithDiscount:F2}");
        }
        else if (accommodationType == "Camping")
        {
            pricePerNight = 10;
            totalPrice = pricePerNight * days;
            priceWithDiscount = totalPrice * 0.9;
            Console.WriteLine($"{priceWithDiscount:F2}");
        }
        break;
}
