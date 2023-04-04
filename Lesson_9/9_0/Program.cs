// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

//input data
Console.Write("Enter the first number: ");
int n = int.Parse(Console.ReadLine()!);

//functions
string PrintNums(int begin, int n)
{
    if (begin == n)
    {
        return begin.ToString();
    }
    return (begin + "  " + PrintNums(begin + 1, n));
}

//result
Console.Write("Result: ");
Console.WriteLine(PrintNums(1, n));