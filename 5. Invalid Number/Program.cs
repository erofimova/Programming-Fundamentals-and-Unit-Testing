//using static System.Runtime.InteropServices.JavaScript.JSType;
//int num = int.Parse(Console.ReadLine());

//bool isValid = (num >= 100 && num <= 200) || num == 0;
//if (!isValid)
//{
//    Console.WriteLine("invalid");
//}

int num = int.Parse(Console.ReadLine());

if (num != 0 && (num > 200 && num < 100))
{
    Console.WriteLine("invalid");
}