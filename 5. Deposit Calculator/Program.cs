double depositAmount = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double annualRate = double.Parse(Console.ReadLine()) / 100;
double finalSum = depositAmount + months * (depositAmount * annualRate) / 12;
Console.WriteLine($"{finalSum:F2}");


