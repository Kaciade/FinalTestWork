string[] array1 = {"Hungary", "Russia", "Germany", "United Kingdom", 
                "France", "Denmark", "Spain", "Romania", "Italy", 
                "Netherlands", "Belgium", "Czech Republic (Czechia)", 
                "Greece", "Portugal", "Sweden"};
string[] array2 = new string [array1.Length];

Console.WriteLine("\nПервоначальный массив:");
for (int i = 0; i < array1.Length; i++) Console.Write($"{array1[i]}\t");

for (int i = 0; i < array1.Length; i++) array2[i] = array1[i];

int count = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (count == 2)
    {
        Console.WriteLine();
        count = 0;
    }
    Console.Write($"{array1[i]}\t");
    count++;
}