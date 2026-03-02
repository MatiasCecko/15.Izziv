using System;
internal class Program
{
    static int MaxSubarraySum(int[] a)
    {
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
        int n = a.Length;

        k = k % n;

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
        RotateRight(b, 2);

        for (int i = 0; i < b.Length; i++)
        {
            Console.Write(b[i] + " ");
        }
        // izpis: 4 5 1 2 3
    }
}