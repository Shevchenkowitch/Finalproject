
void FillArray(string[] array)
{
    string[] array1 = { "hello", "2", "world", ":-)" };
    string[] array2 = { "1234", "1567", "-2", "computer science" };
    string[] array3 = { "Russia", "Denmark", "Kazan" };

    string[][] matrix = new string[][] { array1, array2, array3 };


    for (int i = 0; i < matrix.Length; i++)
    {
       
        int length_array = GetLengthArray(GetArrayLimitLength(matrix[i]));
        PrintArray(GetResArray(GetArrayLimitLength(matrix[i]), length_array));
        
    }


    string[] GetArrayLimitLength(string[] arr)
    {
        string[] res = new string[arr.Length];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                res[j] = arr[i];
                j++;
            }
        }
        return res;
    }
}

void PrintArray(string[] strings)
{
    throw new NotImplementedException();
}

int GetLengthArray(string[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null) cnt++;
    }
    return cnt;
}


string[] GetResArray(string[] arr, int length)
{
    string[] res = new string[length];
    for (int i = 0; i < length; i++)
    {
        res[i] = arr[i];
    }
    return res;
}

FillArray(array1);

