// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


Console.Write("Enter the five-digit number: ");
int set_of_num = int.Parse(Console.ReadLine()!);

if (set_of_num >= 100000 || set_of_num < 1000)
{
    Console.WriteLine($"{set_of_num} is not a five-digit number!");
    return;
}

Palindrome(set_of_num);

void Palindrome(int set_of_num)
{
    int num_12 = set_of_num / 1000;
    int num_5 = set_of_num % 10;
    int num_4 = set_of_num / 10 % 10;

    if (num_12 == num_5 * 10 + num_4)
        Console.WriteLine($"Yes, {set_of_num} is a palindrome!");
    else
        Console.WriteLine($"No, {set_of_num} is not a palindrome!");
}