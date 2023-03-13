// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Пример:
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter 1st number: ");
int num1 = int.Parse(Console.ReadLine()!);

Console.Write("Enter 2nd number: ");
int num2 = int.Parse(Console.ReadLine()!);

if (num1 < num2)
{
    Console.Write($"The number {num1} is less than {num2}");
}
else if (num1 == num2)
{
    Console.Write($"The number {num1} is equal to the number {num2}");
}
else
{
    Console.Write($"The number {num1} is greater than {num2}");
}