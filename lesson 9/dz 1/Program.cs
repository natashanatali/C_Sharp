//  Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N.


void NaturNum(int m, int n)
{
    if (n % 2 != 0)
        n = n - 1;
    if (n < m) return;
    NaturNum(m, n - 2);
    Console.Write($" {n} ");
}

NaturNum(1, 5);
NaturNum(4, 8);