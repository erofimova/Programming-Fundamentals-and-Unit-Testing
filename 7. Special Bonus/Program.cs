int stopNum = int.Parse(Console.ReadLine());

int currentNum = int.Parse(Console.ReadLine());

int previousNum = 0;

while (currentNum != stopNum)
{
    previousNum = currentNum;

    currentNum = int.Parse(Console.ReadLine());
}

Console.WriteLine(previousNum * 1.2);