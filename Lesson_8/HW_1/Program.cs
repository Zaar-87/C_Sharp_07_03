/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

//input data
Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

Console.Write("Enter the min number of massive: ");
int start = int.Parse(Console.ReadLine()!);

Console.Write("Enter the max number of massive: ");
int stop = int.Parse(Console.ReadLine()!);

int[,] mass = MassNums(row_num, column_num, start, stop);

Console.WriteLine();
Console.WriteLine("Initial array: ");
Print(mass);
SumRows(mass);

//Functions

//2D array output
void Print(int[,] array)
{
    int row_size = array.GetLength(0);
    int column_size = array.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

//filling a two-dimensional array with random numbers from a range specified by the user
int[,] MassNums(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = new Random().Next(from, to + 1);

    return array;
}

//finding row with smallest sum of elements
int[,] SumRows(int[,] mass)
{
    int row_size = mass.GetLength(0);
    int column_size = mass.GetLength(1);

    int row_min_numer = 0;
    int sum_min = 0;

    for (int i = 0; i < row_size; i++)
    {
        int sum_row = 0;

        for (int j = 0; j < column_size; j++)
        {
            sum_row += mass[i, j];
        }
        if (i == 0)
        {
            sum_min = sum_row;
            row_min_numer = i;
        }
        else if (sum_min > sum_row)
        {
            sum_min = sum_row;
            row_min_numer = i;
        }

        Console.WriteLine($"sum of elements in row {i + 1} = {sum_row}");
    }
    Console.WriteLine();
    Console.WriteLine($"The smallest sum of elements in row: {row_min_numer + 1}");
    return mass;
}