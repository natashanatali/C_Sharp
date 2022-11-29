// напишите программу вычисления модуля чисел -6->6

Console.Write("Ведите число:");
var S = Console.ReadLine();
int N = S == null ? 0 :int.Parse(S);
Console.WriteLine($"{Math.Abs(N)}");


