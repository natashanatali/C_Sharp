// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
string Nums(int num)
{
    if ((-1000 < num && num <-100) || (num < 1000 && num > 100))
        return $"{num / 10 % 10}";
    return "цифра не трехзначная";    
}
    Console.WriteLine(Nums(int.Parse(Console.ReadLine())));