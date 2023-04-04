//  Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N

//input data
Console.Write("Enter M number: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Enter N number: ");
int n = int.Parse(Console.ReadLine()!);

//functions
string PrintNums(int m, int n)
{
    if (m == n)
    {
        return m.ToString();
    }
    return (m + " " + PrintNums(++m, n));
}

//result
Console.Write("Result: ");
Console.WriteLine(PrintNums(m, n));