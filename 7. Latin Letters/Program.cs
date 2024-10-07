char firstLetter = char.Parse(Console.ReadLine());
char endLetter = char.Parse(Console.ReadLine());

for (char letter = firstLetter; letter <= endLetter; letter++)
{
    Console.Write(letter + " ");
}