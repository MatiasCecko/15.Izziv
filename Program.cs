using System;

class Program
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
            int temp = a[left];
            a[left] = a[right];
            a[right] = temp;

            left++;
            right--;
        }
    }

    static void Main()
    {
        int[] tabela1 = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        Console.WriteLine("Največja vsota podniza: " + MaxSubarraySum(tabela1));

        int[] tabela2 = { 1, 2, 3, 4, 5 };
        int k = 2;

        RotateRight(tabela2, k);

        Console.Write("Zavrtena tabela: ");
        for (int i = 0; i < tabela2.Length; i++)
        {
            Console.Write(tabela2[i] + " ");
        }
    }
}
