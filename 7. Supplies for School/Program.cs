int countPens = int.Parse(Console.ReadLine());
int countMarkers =  int.Parse(Console.ReadLine());
int litersCleaner = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double totalSum = (countPens * 5.80) + (countMarkers * 7.20) + (litersCleaner * 1.20);
double discountAsNumber = discount / 100.0;
totalSum = totalSum - totalSum * discountAsNumber;
Console.WriteLine(totalSum);
