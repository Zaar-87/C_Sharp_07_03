// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.

int num1 = 0;
int num2 = 0;

Console.Write("Write 1st number: ");
num1 = int.Parse(Console.ReadLine()!);

Console.Write("Write 1st number: ");
num2 = int.Parse(Console.ReadLine()!);

if ((num2 * num2) == num1)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}