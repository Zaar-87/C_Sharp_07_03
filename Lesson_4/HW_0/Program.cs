// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Enter a number (A): ");
int num_a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter a degree of number (B): ");
int num_b = int.Parse(Console.ReadLine()!);

double PowNum(int a, int b)
{   
    double n_pow = 1;
    int b_abs = Math.Abs(b);
    
    for (int i = 1; i <= b_abs; i++)
    {
        if (b > 0)
            n_pow *= a; 
        else
            n_pow /= a;
    }  
    return n_pow;  
}

Console.WriteLine($"Result: {PowNum(num_a, num_b)}");