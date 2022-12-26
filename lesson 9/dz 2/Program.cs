﻿//Задайте значение N. Напишите программу, которая выведет все четные натуральные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

//N = 5 -> "2, 4"
//N = 8 -> "2, 4, 6, 8"

Console.WriteLine("Введите натуральное число больше 1:");
int number = int.Parse(Console.ReadLine());

void NumberCounter(int number)
{
    if (number < 0) Console.Write($"{number} не натуральное число");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumberCounter(number - 2);

}

NumberCounter(number);