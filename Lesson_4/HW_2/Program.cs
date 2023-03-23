// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Enter quantity: ");
int quant = int.Parse(Console.ReadLine()!);
Console.Write("Enter beginnig number: ");
int init_from = int.Parse(Console.ReadLine()!);
Console.Write("Enter final number: ");
int init_to = int.Parse(Console.ReadLine()!);

int[] massive = Mass(quant, init_from, init_to);

int[] Mass(int size, int from, int to)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(from, to);
    return array;
}

void Print(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
}

Print(massive);