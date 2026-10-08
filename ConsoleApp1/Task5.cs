int[,] a =
{
    { 5, 2, 8 },
    { 1, 9, 4 },
    { 7, 3, 6 }
};

int min = a[0, 0];
int max = a[0, 0];

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        if (a[i, j] < min)
            min = a[i, j];

        if (a[i, j] > max)
            max = a[i, j];
    }
}
Console.WriteLine("Minimum: " + min);
Console.WriteLine("Maximum: " + max);