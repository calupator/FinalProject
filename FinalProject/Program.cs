void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if ((arr[i] == null))
            break;
        Console.Write("\"" + arr[i] + "\"\t");
    }
    Console.WriteLine();
    Console.WriteLine();
}

int FindElements(ref string[] arr)
{
    string[] result = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[j] = arr[i];
            j++;
        }
    }
    arr = result;
    return j;
}

Console.Clear();

string[] array = {"Program", "64", "Hello", " ", "новая строка", "1234","",  "--", "New", ":-)", "2"};
Console.WriteLine("Начальный массив строк состоит из {0}-элемента(ов):", array.Length);
PrintArray(array);
int count = FindElements(ref array);
Console.WriteLine("Результирующий массив строк состоит из {0}-элемента(ов):", count);
PrintArray(array);