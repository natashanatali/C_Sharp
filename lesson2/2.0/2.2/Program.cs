﻿// 2.2


string Crat(int num, int num2)

{
    if(num % num2 == 0)
        return "кратно";
    else 
        return $"не кратно, остаток = {num % num2}";  
}
Console.WriteLine("1 chislo");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("2 chislo");
int second = int.Parse(Console.ReadLine());
Console.WriteLine(Crat(first, second));

