int[] a = { 2, 5, 8, 3, 9, 1, 6 };

Console.Write("Enter a number: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = 0; i < a.Length; i++)
    if (a[i] < n)
        count++;

Console.WriteLine("Count: " + count);