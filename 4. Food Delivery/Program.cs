int chickenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int vegetarianMenus = int.Parse(Console.ReadLine());

double totalSum = ((chickenMenus * 10.35) + (fishMenus * 12.40) + (vegetarianMenus * 8.15));
double deserts = totalSum * 0.2;
double delivery = 2.50;

Console.WriteLine(totalSum + deserts + delivery);