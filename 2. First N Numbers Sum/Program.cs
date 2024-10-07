int endNumber = int.Parse(Console.ReadLine());
int startNumber = 1;
int sum = 0;
for (int num = startNumber; num <= endNumber; num++)
{
    if (num != endNumber)
    {
        Console.Write(num + "+");
       
    }
    else { Console.Write(num + "="); }
    sum = sum + num;
}
Console.WriteLine(sum);