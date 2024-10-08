int number = int.Parse(Console.ReadLine());
string commands = Console.ReadLine();

while (commands != "End")
{
    if (commands == "Inc")
    {
        number += 1;
        commands = Console.ReadLine();
    }
    else if (commands == "Dec")
    {
        number -= 1;
        commands = Console.ReadLine();
    }

}
Console.WriteLine(number);


