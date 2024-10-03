int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
string mathOperator = Console.ReadLine();

double result = 0;

switch (mathOperator)
{
    case "+": result = num1 + num2; break;
    case "-": result = num1 - num2; break;
    case "*": result = num1 * num2; break;
    case "/": result = num1 / num2; break;
}

Console.WriteLine($"{num1} {mathOperator} {num2} = {result:F2}");
