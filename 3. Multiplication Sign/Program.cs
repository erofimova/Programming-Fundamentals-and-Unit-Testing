int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

ResultSign(num1, num2, num3);

static void ResultSign(int num1, int num2, int num3)
{
    string result = "";
    if (num1 == 0 || num2 == 0 || num3 == 0)
    {
        result = "zero";
    }
    else if ((num1 > 0 && num2 > 0 && num3 > 0) || (num1 < 0 && num2 < 0 && num3 > 0) || (num1 > 0 && num2 < 0 && num3 < 0) || (num1 < 0 && num2 > 0 && num3 < 0))
    {
        result = "positive";
    }
    else
    {
        result = "negative";
    }
    Console.WriteLine(result);
}