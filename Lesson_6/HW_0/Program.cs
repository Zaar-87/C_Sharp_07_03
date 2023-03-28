//Задача 1: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

//Functions
int CountNum()
{
    int count = 0;
    string entered_numbers;

    while (true)
    {
        Console.Write("Enter any number: ");
        entered_numbers = Console.ReadLine()!;

        if (entered_numbers == "") return count;
        else if (int.Parse(entered_numbers) > 0) count += 1;        
    }
}

int count = CountNum();

//result
Console.WriteLine($"Numbers greater than zero: {count}");