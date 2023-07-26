Console.Write("Введите размер массива: ");
{
   {
        int size = int.Parse(Console.ReadLine());

        string[] array = new string[size];
        Console.WriteLine("Введите элементы массива:");

        for (int i = 0; i < size; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            array[i] = Console.ReadLine();
        }

        string[] newArray = FilterArray(array);

        Console.WriteLine("\nНовый массив с длиной строк <= 3:");
        for (int i = 0; i < newArray.Length; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }

    static string[] FilterArray(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                count++;
            }
        }

        string[] filteredArray = new string[count];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                filteredArray[index] = array[i];
                index++;
            }
        }

        return filteredArray;
    }
}