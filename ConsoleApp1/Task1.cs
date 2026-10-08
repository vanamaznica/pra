int[] a = { 1, 2, 3, 2, 4, 5, 1, 6 };

int even = 0, odd = 0, unique = 0;

for (int i = 0; i < a.Length; i++)
{
    if (a[i] % 2 == 0)
        even++;
    else
        odd++;

    bool found = false;

    for (int j = 0; j < i; j++)
        if (a[i] == a[j])
            found = true;

    if (!found)
        unique++;
}
Console.WriteLine("Even: " + even);
Console.WriteLine("Odd: " + odd);
Console.WriteLine("Unique: " + unique);