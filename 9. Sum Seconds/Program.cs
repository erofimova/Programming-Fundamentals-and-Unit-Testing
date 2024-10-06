int athletTime1 = int.Parse(Console.ReadLine());
int athletTime2 = int.Parse(Console.ReadLine());
int athletTime3 = int.Parse(Console.ReadLine());

int secondsTime = athletTime1 + athletTime2 + athletTime3;
int minutes = secondsTime / 60;
int seconds = secondsTime % 60;

Console.WriteLine($"{minutes}:{seconds:D2}");
