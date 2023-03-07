// 2. Напишите программу, которая будет выдавать название дня
//    недели по заданному номеру.

Console.Write("Enter number from 1 to 7: ");
int num = int.Parse(Console.ReadLine()!);
if(num == 1)
{
    Console.Write("monday");
}
else if(num == 2)
{
    Console.Write("tuesday");
}
else if(num == 3)
{
    Console.Write("wednesday");
}
else if(num == 4)
{
    Console.Write("thursday");
}
else if(num == 5)
{
    Console.Write("friday");
}
else if(num == 6)
{
    Console.Write("saturday");
}
else if(num == 7)
{
    Console.Write("sunday");
}
else
{
    Console.WriteLine("error");
}