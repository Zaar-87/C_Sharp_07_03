// 3. Напишите программу, которая на вход принимает одно число
//    (N), а на выходе показывает все целые числа в промежутке от -N до N.


Console.Write("N=");
int n=int.Parse(Console.ReadLine()!);

int count=-n;

while (count!=n)
{
    Console.WriteLine(count);
    if (n<0)
    {
        count--;
    }
    else
    {
        count++;
    }

}
