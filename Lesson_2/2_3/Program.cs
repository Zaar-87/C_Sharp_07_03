﻿// 3. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

//int number = new Random().Next(10, 100);
int a = new Random().Next(100, 1000);

void MyFunc(int num)
{
    Console.WriteLine(num);
    if (num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("Кратно");
    }
    else
    {
        Console.WriteLine("Не кратно");
    }
}

MyFunc(a);