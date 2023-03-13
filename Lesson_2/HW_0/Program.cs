// Задача 1: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

// Пример:
// 456 -> 5 , 782 -> 8 , 918 -> 1

Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()!);
string num_text = Convert.ToString(num);

Console.WriteLine("2nd digit is " + num_text[1]);