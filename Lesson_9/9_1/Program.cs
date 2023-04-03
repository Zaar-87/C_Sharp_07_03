// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

//input data
Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()!);

Console.Write("Enter degree: ");
int degree = int.Parse(Console.ReadLine()!);

//functions
int Pow(int num, int degree)
{
    if (degree == 0) //null
    {
        return 1;
    }
    else if (degree == 1) //one
    {
        return num;
    }
    return (num * Pow(num, --degree));
}

//result
Console.Write("Result: ");
Console.WriteLine(Pow(num, degree));