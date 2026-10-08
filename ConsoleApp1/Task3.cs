int[] a = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };

Console.Write("Enter three numbers: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int z = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; i < a.Length - 2; i++)
    if (a[i] == x && a[i + 1] == y && a[i + 2] == z)
        count++;

Console.WriteLine("Occurrences: " + count);