using System;

class Program
{
    static int MaxSubarraySum(int[] a)
    {
        if (a == null) throw new ArgumentNullException(nameof(a));
        if (a.Length == 0) throw new ArgumentException("Tabela ne sme biti prazna.", nameof(a));

        int best = a[0];
        int current = a[0];

        for (int i = 1; i < a.Length; i++)
        {
            current = Math.Max(a[i], current + a[i]);
            best = Math.Max(best, current);
        }

        return best;
    }

    static void RotateRight(int[] a, int k)
    {
        if (a == null) throw new ArgumentNullException(nameof(a));
        int n = a.Length;
        if (n == 0) return;          // nič za vrtet
        if (n == 1) return;          // tudi nič za vrtet

        k = k % n;                   // zmanjšamo k
        if (k < 0) k += n;           // če je k negativen, ga popravimo
        if (k == 0) return;          // brez spremembe

        Reverse(a, 0, n - 1);
        Reverse(a, 0, k - 1);
        Reverse(a, k, n - 1);
    }

    static void Reverse(int[] a, int left, int right)
    {
        while (left < right)
        {
            int tmp = a[left];
            a[left] = a[right];
            a[right] = tmp;

            left++;
            right--;
        }
    }

    static void Main()
    {
        int[] a = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine(MaxSubarraySum(a)); // 6

        int[] b = { 1, 2, 3, 4, 5 };
        RotateRight(b, 2); // 4 5 1 2 3

        for (int i = 0; i < b.Length; i++)
            Console.Write(b[i] + " ");
    }
}
