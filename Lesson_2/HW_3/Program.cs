// Задача 4: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// Пример:
// 6 -> да , 7 -> да , 1 -> нет


Console.Write("Enter the number of a day of the week: ");
int num_w_d = int.Parse(Console.ReadLine()!);
Result(num_w_d);

void Result(int num_w_d)
{
    if (num_w_d == 6 || num_w_d == 7)
    {
        Console.WriteLine("This is a day off!");
    }
    else if (num_w_d < 6)
    {
        Console.WriteLine("This is a working day :(");
    }
}