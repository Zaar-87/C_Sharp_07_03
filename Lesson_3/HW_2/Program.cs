// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enter the number: ");
Cubes(int.Parse(Console.ReadLine()!));

void Cubes(int n)
{
    double[] numbers = new double[n];
    int i = 0;

    Console.Write($"From 1 up to {n} you have such cube values: ");

    while (i < n)
    {
        numbers[i] = Math.Pow((i + 1), 3);
        Console.Write($"{numbers[i]} ");
        i++;
    }
    Console.WriteLine();
}