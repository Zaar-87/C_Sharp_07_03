/*
Задача 60. Задайте двумерный массив из целых чисел. Напишите программу,
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
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

int[] new_mass = MinElement(mass);

//finding min element
int[] MinElement(int[,] array)
{
    int row = array.GetLength(0);
    int column = array.GetLength(1);

    int min_num = array[0, 0];
    
    int[] index = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (min_num > array[i, j])
            {
                min_num = array[i, j];
                index[0] = i;
                index[1] = j;
            }
    }
    Console.Write($"Minimum element on position '{index[0]+1},{index[1]+1}': ");
    Console.WriteLine(array[index[0], index[1]]);
    return index;
}

int[,] res_mass = DeleteRowColumn(mass, new_mass);

//deleting row and column
int[,] DeleteRowColumn(int[,] array, int[] mass2)
{
    int row_num_new = array.GetLength(0);
    int column_num_new = array.GetLength(1);

    int k = 0;
    int l = 0;

    int[,] new_mass = new int[row_num_new - 1, column_num_new - 1];

    for (int i = 0; i < row_num_new; i++)
    {
        for (int j = 0; j < column_num_new; j++)
        {
            if (mass2[0] != i && mass2[1] != j)
            {
                new_mass[k, l] = array[i, j];
                l ++;
            }
        }
        l = 0;        
        if (mass2[0] != i) 
            k ++;        
    }
    return new_mass;
}

//result
Console.WriteLine("Result massive:");
Print(res_mass);