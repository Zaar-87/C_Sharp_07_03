﻿// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

//input data
Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()!);

//functions
long GetSum(long num)
{
    if (num == 0) //null
    {
        return 0;
    }
    return (num % 10 + GetSum(num / 10));
}

//result
Console.Write("Result: ");
Console.WriteLine(GetSum(num));