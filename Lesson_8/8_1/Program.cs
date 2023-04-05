//Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно,
//программа должна вывести сообщение для пользователя.

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
//Standart ^

//array transparent function
int[,] TransparentMass(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    int[,] t_array = new int[row_size, column_size];

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            t_array[i, j] = arr[j, i];
    }
    return t_array;
}

//checking and if false -> transpar array
void CheckAndTranspar()
{
    if (mass.GetLength(0) != mass.GetLength(1))
    {
        Console.WriteLine("Fail to transpose non-square mass!");
        return;
    }
    int[,] arr_new = TransparentMass(mass);
    Console.WriteLine("Result array: ");
    Print(arr_new);
}

//Console result
Console.WriteLine();
Console.WriteLine("Initial array: ");
Print(mass);
CheckAndTranspar();