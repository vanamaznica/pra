int[] a = { 1, 2, 3, 4, 5 };
int[] b = { 3, 4, 5, 6, 7 };
int[] c = new int[a.Length];
int k = 0;

for (int i = 0; i < a.Length; i++)
{
    for (int j = 0; j < b.Length; j++)
    {
        if (a[i] == b[j])
        {
            bool found = false;

            for (int t = 0; t < k; t++)
                if (c[t] == a[i])
                    found = true;

            if (!found)
                c[k++] = a[i];

            break;
        }
    }
}
Console.WriteLine("Common elements:");

for (int i = 0; i < k; i++)
    Console.Write(c[i] + " ");