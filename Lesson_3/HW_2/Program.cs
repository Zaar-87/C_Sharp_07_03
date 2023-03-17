// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enter the number: ");
Squares(int.Parse(Console.ReadLine()!));

void Squares(int n)
{
    double[] numbers = new double[n];
    int i = 0;

    Console.Write($"Number {n} gives you such cube table : ");

    while (i < n)
    {
        numbers[i] = Math.Pow((i + 1), 3);
        Console.Write($"{numbers[i]} ");
        i += 1;
    }    
    Console.WriteLine();
}