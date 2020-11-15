using System;

namespace mergesort
{
    class Program
    {
        static int[] Sort(int[] arr, int beg, int end)
        {
            int[] retval;

            if (end - beg == 1) 
            {
                retval = new int[] { arr[beg] };
                return retval;
            }

            var cut = beg + (end - beg) / 2;
            var lhs = Sort(arr, beg, cut);
            var rhs = Sort(arr, cut, end);

            // merge
            retval = new int[end - beg];
            var nlhs = 0;                       // 0 to cut
            var nrhs = 0;                       // 0 to end - cut;

            while (true) 
            {
                if (nlhs + nrhs >= end - beg) 
                {
                    break;
                }

                if (nlhs == lhs.Length)
                {
                    retval[nlhs + nrhs] = rhs[nrhs];
                    nrhs++;
                    continue;
                }
                
                if (nrhs == rhs.Length)
                {
                    retval[nlhs + nrhs] = lhs[nlhs];
                    nlhs++;
                    continue;
                }

                if (lhs[nlhs] < rhs[nrhs])
                {
                    retval[nlhs + nrhs] = lhs[nlhs];
                    nlhs++;
                }
                else 
                {
                    retval[nlhs + nrhs] = rhs[nrhs];
                    nrhs++;
                }
            }

            return retval;
        }

        static int Main(string[] args)
        {
            int[] arr = { 3, 5, 8, 2, 1, 1, 2, 3, 7, 1, 1, 1 };

            arr = Sort(arr, 0, arr.Length);

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    Console.WriteLine("error!");
                    return 1;
                }
            }

            return 0;
        }
    }
}
