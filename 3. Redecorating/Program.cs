int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int thinner = int.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());
 
double sumMaterials = ((nylon + 2) * 1.5) + ((paint + paint * 0.1) * 14.5) + (thinner * 5) + 0.4;
double sumCraftsmen = (sumMaterials * 0.30) * hours;
double totalSum = sumCraftsmen + sumMaterials;
Console.WriteLine(totalSum);