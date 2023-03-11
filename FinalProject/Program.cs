Console.Write("\nУкажите количество элементов массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите левую часть диапазона массива: ");
int min = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите правую часть диапазона массива: ");
int max = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int [length];
Random random = new Random();

for (int i = 0; i < array.Length; i++) array[i] = random.Next(min, max);

Console.WriteLine("\nПервоначальный массив:");
for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]}\t");

