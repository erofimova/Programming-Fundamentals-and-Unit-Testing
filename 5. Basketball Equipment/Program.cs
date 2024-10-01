int yearFee = int.Parse(Console.ReadLine());
double sneekers = yearFee * 0.6;
double uniforms = sneekers * 0.8;
double balls = uniforms / 4;
double accessories = balls / 5;

double totalSum = sneekers + uniforms + balls + accessories + yearFee;
Console.WriteLine(totalSum);
