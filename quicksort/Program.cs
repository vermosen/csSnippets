using System;

namespace quicksort
{
    class Program
    {
        static int partition(ref int[] arr, int lo, int hi) {
            
            var pivot = arr[lo];
            
            
            return lo;
        }

        static void sort(ref int[] arr, int lo, int hi) {

            if (hi != lo)
            {
                var res = partition(ref arr, lo, hi);
                sort(ref arr, lo, res);
                sort(ref arr, res + 1, hi);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 8, 1, 2, 3, 7 };

            sort(ref arr, 0, arr.Length - 1);

            for (int i = 1; i < arr.Length; i++) {
                if (arr[i] < arr[i - 1]) {
                    Console.WriteLine("error!");
                }
            }

        }
    }
}
