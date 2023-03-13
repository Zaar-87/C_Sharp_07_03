// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Пример:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter the number: ");
int num1 = int.Parse(Console.ReadLine()!);
int ind = 2;

while (ind <= num1)
{
    Console.Write($"{ind}, ");
    ind = ind + 2;
}