// Задача 3: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// Пример:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter the number: ");
int num = int.Parse(Console.ReadLine()!);
string num_text = Convert.ToString(num);

if (num_text.Length > 2)
{
  Console.WriteLine("Third Digit is " + num_text[2]);
}
else 
{
  Console.WriteLine("There is no 3d digit");
}