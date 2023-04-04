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
    if (m == n) return m.ToString();
    if (m % 2 != 0) return ((m+1) + " " + PrintNums(++m, n));
    else return (m + " " + PrintNums(m + 2, n));
}

//result
Console.Write($"M = {m}, N = {n}. Numbers between M & N: ");
Console.WriteLine(PrintNums(m, n));

/*
using System.Text;

IReadOnlyCollection<int> FindEvenNaturalNumbers(int m, int n)
{
    if (m <= 0) // m is not natural number
        m = 2;
    else if (m % 2 == 1) // m is odd number
        m++;

    var evenNaturalNumbers = new List<int>();
    for (;  m <= n; m += 2)
    {
        evenNaturalNumbers.Add(m);
    }

    return evenNaturalNumbers;
}

string GetStringArray(in IReadOnlyCollection<int> array, string delimeter = ", ")
{
    var arrOutput = new StringBuilder();

    foreach (var item in array)
    {
        arrOutput.Append(item);
    }

    return string.Join(delimeter, array).Trim();
}

Console.Write("Введите M: ");
var m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
var n = int.Parse(Console.ReadLine()!);

var evenNaturalNumbers = FindEvenNaturalNumbers(m, n);
Console.WriteLine($"M={m}; N={n} ->  {GetStringArray(evenNaturalNumbers)}");
*/