Console.WriteLine("Введите элементы массива строк (разделенные пробелом):");
string[] input = Console.ReadLine()!.Split(' ');

string[] result = FilterStrings(input);

Console.WriteLine("Результат:");
foreach (string str in result)
{
    Console.WriteLine(str);
}


static string[] FilterStrings(string[] strings)
{
    int count = 0;
    
    foreach (string str in strings)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    
    string[] result = new string[count];

    int index = 0;
    
    foreach (string str in strings)
    {
        if (str.Length <= 3)
        {
            result[index] = str;
            index++;
        }
    }

    return result;
}
