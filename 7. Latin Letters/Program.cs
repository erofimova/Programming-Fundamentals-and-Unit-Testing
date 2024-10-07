char firstLetter = char.Parse(Console.ReadLine());
char endLetter = char.Parse(Console.ReadLine());

for (int letter = firstLetter; letter <= endLetter; letter++)
{
    Console.Write((char)letter + " ");
}