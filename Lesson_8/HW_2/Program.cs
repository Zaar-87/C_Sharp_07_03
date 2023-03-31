/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

//input data
Console.WriteLine("Attributes for FIRST array");
Console.Write("Enter the number of rows: ");
int row_num1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the min number of massive: ");
int start1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive: ");
int stop1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Attributes for Second array");
Console.Write("Enter the number of rows: ");
int row_num2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the min number of massive: ");
int start2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter the max number of massive: ");
int stop2 = int.Parse(Console.ReadLine()!);

int[,] array1 = ArrayNums(row_num1, column_num1, start1, stop1);
int[,] array2 = ArrayNums(row_num2, column_num2, start2, stop2);

Console.WriteLine();
Console.WriteLine("Initial First array: ");
Print(array1);
Console.WriteLine("Initial Second array: ");
Print(array2);

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
int[,] ArrayNums(int row, int column, int from, int to)
{
    int[,] array = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            array[i, j] = new Random().Next(from, to + 1);
    return array;
}

//function of multiplication of two consistent arrays/matrices
int[,] ArraysMultiplication(int[,] array1, int[,] array2)
{
    int row_size_1 = array1.GetLength(0);
    int column_size_1 = array1.GetLength(1);
    int row_size_2 = array2.GetLength(0);
    int column_size_2 = array2.GetLength(1);
    
    int[,] resultArray = new int[row_size_1, column_size_2];
    int row_size_res = resultArray.GetLength(0);
    int column_size_res = resultArray.GetLength(1); 

    if (column_size_1 == row_size_2)
    {
        for (int i = 0; i < row_size_res; i++)
        {
            for (int j = 0; j < column_size_res; j++)
            {
                resultArray[i, j] = 0;
                for (int k = 0; k < column_size_1; k++)
                {
                    resultArray[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("ERROR! Multiplication of given arrays is not possible!");
    }
    return resultArray;
}

//result
Console.WriteLine("Result of arrays multiplication:");
int[,] resultArray = ArraysMultiplication(array1, array2);
Print(resultArray);