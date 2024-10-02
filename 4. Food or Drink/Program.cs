using System.Threading;
using System;
string product = Console.Readline();

if (product == curry || noodles || sushi || spaghetti || bread)
{
    Console.WriteLine("food");
}
else if (product == tea || water || coffee || juice)
{
    Console.WriteLine("drink");
}
else
{
    Console.WriteLine("unknown");
}
