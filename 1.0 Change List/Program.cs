List<int> numbers = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToList();

string input = Console.ReadLine();

while (input != "end")
{

    string[] commandParts = input.Split(" ");
    string commandName = commandParts[0];

    if (commandName == "Delete")
    {
        int elementForDelete = int.Parse(commandParts[1]);
        while (numbers.Contains(elementForDelete))
        {
            numbers.Remove(elementForDelete);
        }
    }
    else if (commandName == "Insert")
    {
        int elementForInsert = int.Parse(commandParts[1]);
        int positionForInsert = int.Parse(commandParts[2]);
        numbers.Insert(positionForInsert, elementForInsert);
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));