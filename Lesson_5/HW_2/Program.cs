//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Write("Enter quantity: ");
int quant = int.Parse(Console.ReadLine()!);
Console.Write("Enter beginnig number: ");
int init_from = int.Parse(Console.ReadLine()!);
Console.Write("Enter final number: ");
int init_to = int.Parse(Console.ReadLine()!);

double[] massive = Mass(quant, init_from, init_to);

Console.WriteLine($"Generated array: ");
Print(massive);
CompareDiff(massive);
Console.WriteLine();

//Functions
double[] Mass(int size, int from, int to)
{
    double[] array = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
        array[i] = Math.Round(n_new.NextDouble() * (to - from) + from, 2);
    return array;
}

void Print(double[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)    
        Console.Write($"{array[i]} ");
    
    Console.WriteLine();
}

void CompareDiff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i]; 
        else if (array[i] > max)
            max = array[i];
    }
    Console.Write($"Minimum number: {min}, Maximum number: {max}. ");
    Console.WriteLine();
    Console.WriteLine($"Difference: {max} - ({min}) = {Math.Round(max - min, 2)}");
}