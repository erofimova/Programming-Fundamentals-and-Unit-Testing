int[] numArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

for (int i = 0; i < numArray.Length - 1; i++)
{
    bool isGreater = true;

    int currentElement = numArray[i];

    for (int j = i + 1; j < numArray.Length; j++)
    {
        int nextRightElement = numArray[j];

        if (nextRightElement >= currentElement)
        {
            isGreater = false;
            break;
        }
    }

    if (isGreater)
    {
        Console.Write(currentElement + " ");
    }
}

Console.Write(numArray[numArray.Length - 1]);