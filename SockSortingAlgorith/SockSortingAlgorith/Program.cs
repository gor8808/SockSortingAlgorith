using System;

namespace SockSortingAlgorith
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter socks count");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter colors");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(" "), arTemp => Convert.ToInt32(arTemp));
            int result = SockMerchant(n,arr);
            Console.WriteLine("\n");
            Console.WriteLine($"Result -- {result}");
        }

        private static int SockMerchant(int n, int[] arr)
        {
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] == 0) { continue; }
                    else
                    {
                        if (arr[i] == arr[j])
                        {
                            arr[i] = 0;
                            arr[j] = 0;
                            result++;
                        }
                    }
                }

            }


            return result;
        }
    }
}
