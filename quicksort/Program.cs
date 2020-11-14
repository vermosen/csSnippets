using System;

namespace quicksort
{
    class Program
    {
        static void swap(ref int a, ref int b) {
            int temp = b;
            b = a       ;
            a = temp    ;
        }
        static int partition(int[] arr, int beg, int end) {

            var piv = arr[beg];
            var bbeg = beg + 1; 
            var eend = end;

            while (true)
            {
                while (eend > bbeg && arr[eend - 1] >= piv)
                {
                    eend--;
                }

                while (bbeg < eend && arr[bbeg] <= piv)
                {
                    bbeg++;
                }

                if (bbeg < eend)
                {
                    swap(ref arr[bbeg], ref arr[eend - 1]);
                }
                else
                {
                    if (arr[beg] > arr[bbeg - 1]) {
                        swap(ref arr[beg], ref arr[bbeg - 1]);
                    }
                    return bbeg;
                }
            }
        }

        static void sort(int[] arr, int beg, int end) {

            if (beg < end - 1)
            {
                var pos = partition(arr, beg, end);
                sort(arr, beg, pos);
                sort(arr, pos, end);
            }
        }

        static int Main(string[] args)
        {
            int[] arr = { 3, 5, 8, 2, 1, 1, 2, 3, 7, 1, 1, 1 };

            sort(arr, 0, arr.Length);

            for (int i = 1; i < arr.Length; i++) {
                if (arr[i] < arr[i - 1]) {
                    Console.WriteLine("error!");
                    return 1;
                }
            }

            return 0;
        }
    }
}
