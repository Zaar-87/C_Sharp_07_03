/*
Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные
натуральные числа в промежутке от M до N с помощью рекурсии.

M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

//input data
Console.Write("Enter M number: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Enter N number: ");
int n = int.Parse(Console.ReadLine()!);

//functions
string PrintNums(int m, int n)
{
    if (m > n)
    {
        return "Error! N < M !";
    }

    if (m % 2 == 0) //even M
    {
        if (m == n)
        {
            return m.ToString();
        }
        return (m + " " + PrintNums(++m, n));
    }

    if (m % 2 == 1) //odd M
    {
        if (m == n)
        {
            return String.Empty;
        }
        return (PrintNums(m + 1, n));
    }

    if (m < 0) //for odd negative M
    {
        return (PrintNums(m + 1, n));
    }

    else return "Error!";
}

//result
Console.Write($"M = {m}, N = {n}. Even numbers between M & N: ");
Console.WriteLine(PrintNums(m, n));