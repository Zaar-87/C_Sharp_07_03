// Задача 2: Напишите программу, которая выводит 
// случайное трёхзначное число и удаляет вторую цифру этого числа.

// Пример:
// 456 -> 46 , 782 -> 72 , 918 -> 98

int num = GenerateNumber();
Console.WriteLine(num);
string num_text = Convert.ToString(num);
Console.WriteLine("Result is: " + num_text[0] + num_text[2]);

int GenerateNumber()
{
    int num = new Random().Next(100, 1000);
    return num;
}