/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

//sorting elements in lines by decreasing
void LineElDecreasing(int[,] mass)
{
    int row_size = mass.GetLength(0);
    int column_size = mass.GetLength(1);

    for (int i = 0; i < row_size; i++)
        for (int j = 0; j < column_size; j++)
            for (int decr = 0; decr < column_size - 1; decr++)
            {
                int column = decr + 1;
                if (mass[i, column] > mass[i, decr])
                {
                    int tmp = mass[i, column];
                    mass[i, column] = mass[i, decr];
                    mass[i, decr] = tmp;
                }
            }
}

//result
LineElDecreasing(mass);
Console.WriteLine("Array sorted in descending order: ");
Print(mass);