//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Write("Enter quantity: ");
int quant = int.Parse(Console.ReadLine()!);
Console.Write("Enter beginnig number: ");
int init_from = int.Parse(Console.ReadLine()!);
Console.Write("Enter final number: ");
int init_to = int.Parse(Console.ReadLine()!);

int[] massive = Mass(quant, init_from, init_to);

Print(massive);
Console.WriteLine();
Console.WriteLine(Compare(massive));

//Functions
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

int Compare(int[] array)
{
    int min = array[0];
    int max = array[0];
    int diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
        {
            min = array[i];
        } 
        else
        {
            max = array[i];
        } 
    }
    diff = max - min;
    return diff;
}