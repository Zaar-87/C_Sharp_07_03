// 2-й вариант "задачи 19" через индексы

Console.Write("Enter the five-digit number: ");
int set_of_num = int.Parse(Console.ReadLine()!);

if (set_of_num >= 100000 || set_of_num < 10000)
{
    Console.WriteLine($"{set_of_num} is not a five-digit number!");
    return;
}

Palindrome_i(set_of_num);

void Palindrome_i(int set_of_num)
{
    string num = set_of_num.ToString();
    int size = num.Length - 1;
    string result_text = "is a palindrome!";
    
    for (int i = 0; i < size / 2; i++)
    {
        if (num[i] != num[size - i])
        {
            result_text = "is NOT a palindrome!";
            break;
        }
    }
    Console.WriteLine($"{set_of_num} {result_text}");
}
