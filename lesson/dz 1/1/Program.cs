// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ведите целое число1");
string neme1 = Console.ReadLine();
int num1 = int.Parse(neme1);

Console.WriteLine("Ведите целое число2");
string neme2 = Console.ReadLine();
int num2 = int.Parse(neme2);

if (num1 > num2)
{
    Console.Write($"число {num1}больше чем {num2}");
}
else if (num1 == num2)
{
    Console.Write($"число{num1}равно числу {num2}");
}
else
{
    Console.Write($"число {num2}больше чем {num1}");
}