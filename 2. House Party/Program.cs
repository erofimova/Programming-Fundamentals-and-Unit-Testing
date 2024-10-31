int countCommands = int.Parse(Console.ReadLine());

List<string> guestsList = new List<string>();

for (int count = 1; count <= countCommands; count++)
{
    string command = Console.ReadLine();
    string[] commandParts = command.Split(" ");
    string name = commandParts[0]; //име на гост

    if (commandParts.Length == 3)
    {

        if (guestsList.Contains(name))
        {
            Console.WriteLine($"{name} is already in the list!");
        }
        else
        {
            guestsList.Add(name);
        }

    }
    else if (commandParts.Length == 4)
    {
        if (guestsList.Contains(name))
        {
            guestsList.Remove(name);
        }
        else
        {
            Console.WriteLine($"{name} is not in the list!");
        }
    }
}

foreach (string guestName in guestsList)
{
    Console.WriteLine(guestName);
}