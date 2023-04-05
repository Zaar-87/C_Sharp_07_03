/*
4. Напишите программу, которая на вход принимает два числа A и B,
   и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

//input data
Console.Write("Enter the first number: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter the second number (exp): ");
int num2 = int.Parse(Console.ReadLine()!);

//functions
int Pow(int num1, int num2)
{
    if (num2 == 0)  return 1; //null
        if (num2 == 1) return num1; //selfreturn
            return (num1 * Pow(num1, (num2 - 1))); //exponentiation
}

//result
Console.Write("Result: ");
Console.WriteLine(Pow(num1, num2));