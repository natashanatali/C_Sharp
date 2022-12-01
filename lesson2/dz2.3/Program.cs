// Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

string Week(int data)
{
    if (data == 6 || data == 7)
        return "выходной день";
    else
        return "будний день";           
}

Console.WriteLine("Введите номер:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Week(num));
