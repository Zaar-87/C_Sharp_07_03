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
int[,] matrix = new int[row_num - 1, column_num - 1];

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

//finding min element
int[] MinEl(int[,] arr)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int min_num = arr[0, 0];
    int[] indexes = new int[2];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
            if (min_num > arr[i, j])
            {
                min_num = arr[i, j];
                indexes[0] = i;
                indexes[1] = j;
            }
    }
    Console.Write($"Minimum element on position '{indexes[0]+1},{indexes[1]+1}': ");
    Console.WriteLine(arr[indexes[0], indexes[1]]);
    return indexes;
}

//deleting row and column
int[,] WithoutRowColumn(int[,] arr, int[] m_indexes)
{
    int k = 0;
    int p = 0;
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);
    int[,] new_matr = new int[row - 1, column - 1];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            if (m_indexes[0] != i && m_indexes[1] != j)
            {
                new_matr[k, p] = arr[i, j];
                p += 1;
            }
        }
        p = 0;        
        if (m_indexes[0] != i) k += 1;        
    }
    return new_matr;
}

//result
int[] new_mass = MinEl(mass);
int[,] res_mass = WithoutRowColumn(mass, new_mass);
Console.WriteLine("Result massive:");
Print(res_mass);