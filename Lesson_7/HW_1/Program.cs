/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

Console.Write("Enter the number line: ");
int i_n = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number column: ");
int j_n = int.Parse(Console.ReadLine()!);

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

//number lookup function
string FindNum(int[,] array, int i_n, int j_n)
{
    if (i_n > array.GetLength(0) || i_n <=0 && j_n > array.GetLength(1) || j_n <=0)
    {
        return "ERROR! Out of range both parameters!";
    }
    else if (i_n > array.GetLength(0) || i_n <=0)
    {
        return "ERROR! Out of range (line)!";
    }
    else if (j_n > array.GetLength(1) || j_n <=0)
    {
        return "ERROR! Out of range (column)!";
    }
    else
    {
        return $"{array[i_n-1,j_n-1]}";
    }
}

//result
Console.WriteLine();
Console.Write($"The number in this position is: {FindNum(mass, i_n, j_n)}");