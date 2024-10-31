List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

string command = Console.ReadLine();

while (command != "End")
{
    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0];

    switch (commandName)
    {
        case "Add":

            int numberToAdd = int.Parse(commandParts[1]);
            numbers.Add(numberToAdd);
            break;
        case "Insert":

            int numberToInsert = int.Parse(commandParts[1]);
            int positionToInsert = int.Parse(commandParts[2]);

            if (positionToInsert >= 0 && positionToInsert <= numbers.Count - 1)
            {
                numbers.Insert(positionToInsert, numberToInsert);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            break;
        case "Remove":
            int positionToRemove = int.Parse(commandParts[1]);

            if (positionToRemove >= 0 && positionToRemove <= numbers.Count - 1)
            {
                numbers.RemoveAt(positionToRemove);
            }
            else
            {
                Console.WriteLine("Invalid index");
            }
            break;
        case "Shift":
            string position = commandParts[1];
            int count = int.Parse(commandParts[2]);
            if (position == "left")
            {
                for (int i = 1; i <= count; i++)
                {
                    int firstNumber = numbers[0];
                    numbers.RemoveAt(0);
                    numbers.Add(firstNumber);
                }

            }
            else if (position == "right")
            {
                for (int i = 1; i <= count; i++)
                {
                    int lastNumber = numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);
                    numbers.Insert(0, lastNumber);
                }
            }
            break;
    }

    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));