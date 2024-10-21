int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());

int firstFactorial = FindFactolial(firstNum);
int secondFactorial = FindFactolial(secondNum);
int result = firstFactorial / secondFactorial;
Console.WriteLine(result);

static int FindFactolial(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {

        factorial = factorial * i;
    }
    return factorial;
}
