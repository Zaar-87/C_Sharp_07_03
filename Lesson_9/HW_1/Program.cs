/*
Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

//input data
Console.Write("Enter M number: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Enter N number: ");
int n = int.Parse(Console.ReadLine()!);

//functions
int SumNums(int m, int n)
{
    if (m == n) return m;
        return (m + SumNums(m + 1, n));
}

//result
Console.Write($"Sum of numbers between {m} & {n} is ");
Console.WriteLine(SumNums(m, n));