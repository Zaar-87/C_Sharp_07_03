//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Write("Enter quantity of numbers in array: ");
int n = int.Parse(Console.ReadLine()!);

int[] array = GenerateArray();
Print(array);
Console.WriteLine(EvenNumbersQuant(array));

//Functions
int[] GenerateArray()
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = GenerateNumber();
    }
    return arr;
}

int GenerateNumber()
{
    int num = new Random().Next(100, 1000);
    return num;
}

void Print(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{array[i]} ");
}

int EvenNumbersQuant(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
