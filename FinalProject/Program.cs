Console.Clear();

string[] array1 = {"123", "15", "Germany", "XD", 
                "France", "Denmark", "LOL", "adpgkn", "xyz", 
                "Netherlands", "AZN", "RUS", 
                "Greece", "0987q4t", ":-)"};

Console.WriteLine("\nПервоначальный массив:");
for (int i = 0; i < array1.Length; i++) Console.Write($"{array1[i]}   |   ");

int count = 0;
Console.WriteLine();
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        count++;
    }
}

int j = 0;
string[] array2 = new string [count];
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[j] = array1[i];
        j++;
    }
}

Console.WriteLine("\nНовый массив из строк, длина которых меньше либо равна 3 символам:");
for (int i = 0; i < array2.Length; i++) Console.Write($"{array2[i]}   |   ");