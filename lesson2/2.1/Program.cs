// напишите программу,которая выводит случайное число трехзначное ,и на выходе покаывает последнюю цифру этого числа.

int Num(int num)
{
   Console.WriteLine(num);

    return num %10;
}
Console.WriteLine(Num(new Random().Next(100,1000)));
