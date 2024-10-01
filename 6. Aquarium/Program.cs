int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());  
double percentage = double.Parse(Console.ReadLine()); 

int volumeInCm3 = length * width * height;
double volumeInLiters = volumeInCm3 / 1000.0;
double usableVolume = volumeInLiters * (1 - percentage / 100);
Console.WriteLine($"{usableVolume:F2}");