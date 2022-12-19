﻿/// 2. Задайте одномерный массив, заполненный случайными числами.
//    Найдите сумму элементов, стоящих на нечётных позициях. 


void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 1; i < size; i++)
    {
        arr[i] = new Random().Next(from, to);
    }
    return arr;
}

int OddNumSum(int[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i += 2)
    {
        count += arr[i];
    }
    return count;
}

int[] arr_1 = MassNums(10, 1, 11);
Print(arr_1);
Console.WriteLine(OddNumSum(arr_1));

int[] arr_2 = MassNums(4, 1, 11);
Print(arr_2);
Console.WriteLine(OddNumSum(arr_2));
