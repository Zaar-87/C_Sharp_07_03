// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Enter 1st X coordinate: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter 1st Y coordinate: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter 1st Z coordinate: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.Write("Enter 2nd X coordinate: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter 2nd Y coordinate: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Enter 2nd Z coordinate: ");
int z2 = int.Parse(Console.ReadLine()!);

double Line(int x_1, int y_1, int z_1, int x_2, int y_2, int z_2)
{
    return Math.Round(Math.Sqrt(Math.Pow(x_2 - x_1, 2) + Math.Pow(y_2 - y_1, 2) + Math.Pow(z_2 - z_1, 2)), 2);
}

double res = Line(x1, y1, z1, x2, y2, z2);
Console.WriteLine(res);