//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Write("Enter quantity: ");
int quant = int.Parse(Console.ReadLine()!);
Console.Write("Enter beginnig number: ");
int init_from = int.Parse(Console.ReadLine()!);
Console.Write("Enter final number: ");
int init_to = int.Parse(Console.ReadLine()!);

int[] massive = Mass(quant, init_from, init_to);

Print(massive);
Console.WriteLine();
Console.WriteLine(ElementsSumOnOdd(massive));

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

int ElementsSumOnOdd(int[] massive)
{
    int sum = 0;
    for (int i = 0; i < massive.Length; i=i+2)
    {
        sum = sum + massive[i];
    }
    return sum;
}