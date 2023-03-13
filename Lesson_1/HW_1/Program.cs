// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Пример:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter 1st number: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter 2nd number: ");
int num2 = int.Parse(Console.ReadLine()!);

Console.Write("Enter 3d number: ");
int num3 = int.Parse(Console.ReadLine()!);

if (num1 < num2)
{
    num1 = num2;
}
if (num1 < num3)
{
    num1 = num3;
}

Console.Write($"The number {num1} is the largest");