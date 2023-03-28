//Задача 2: Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное.
//45 -> 101101 
//3  -> 11
//2  -> 10

int num = GetUserNumber("number");
Console.WriteLine(MakeBinary(num));

int GetUserNumber(string name)
{
    int number = 0;
    Console.Write($"Please enter {name}: ");
    number = int.Parse(Console.ReadLine()!);
    return number;
}

string MakeBinary(int number)
{
    string binary = "";

    while (number > 0)
    {
        binary = number%2 + binary;
        number /= 2;
    }
    return binary;
}