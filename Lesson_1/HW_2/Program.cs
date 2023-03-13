// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Пример:
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter the number for checking: ");
int num1 = int.Parse(Console.ReadLine()!);

if (num1 % 2 == 0)
{
    Console.Write($"The number {num1} is even");
}
else
{
    Console.Write($"The number {num1} is odd");
}