double tomatoPrice = double.Parse(Console.ReadLine());
double tomatoQuantity = double.Parse(Console.ReadLine());
double cucumberPrice  = double.Parse(Console.ReadLine());
double cucumberQuantity = double.Parse(Console.ReadLine());
double totalPrice = (tomatoPrice * tomatoQuantity) + (cucumberPrice * cucumberQuantity);
Console.WriteLine($"{totalPrice:F2}");