// 2. Напишите программу, которая будет выдавать название дня
//    недели по заданному номеру.

Console.Write("Enter number from 1 to 7: ");
int num = int.Parse(Console.ReadLine()!);
if (num == 1)
{
    Console.Write("Monday");
}
else if (num == 2)
{
    Console.Write("Tuesday");
}
else if (num == 3)
{
    Console.Write("Wednesday");
}
else if (num == 4)
{
    Console.Write("Thursday");
}
else if (num == 5)
{
    Console.Write("Friday");
}
else if (num == 6)
{
    Console.Write("Saturday");
}
else if (num == 7)
{
    Console.Write("Sunday");
}
else
{
    Console.WriteLine("Тumber is out of range!");
}