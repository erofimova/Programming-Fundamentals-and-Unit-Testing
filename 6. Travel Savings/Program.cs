string destination = Console.ReadLine();


while (destination != "End")
{
    double sum = 0;
    double budget = double.Parse(Console.ReadLine());

    while (sum < budget)
    {
        sum += double.Parse(Console.ReadLine());
        Console.WriteLine($"Collected: {sum:F2}");
    }
    Console.WriteLine($"Going to {destination}!");

    destination = Console.ReadLine();

}
