using System;

namespace Quick
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = new int[] { 5, 2, 7, 4, 1, 6, 3 };
            Quicksort(data, 0, data.Length-1);
            var output = string.Join(", ", data);
            Console.WriteLine(output);
        }

        static void Quicksort(int[] data, int begin, int end)
        {
            if (begin < end)
            {
                var mid = Partition(data, begin, end);
                Quicksort(data, begin, mid - 1);
                Quicksort(data, mid + 1, end);
            }
        }

        static int Partition(int[] data, int begin, int end)
        {
            var pivot = data[begin];
            var rightBegin = begin + 1;

            for(var i=rightBegin; i <= end; i++)
            {
                if (data[i] < pivot)
                {
                    Swap(data, i, rightBegin);
                    rightBegin++;
                }
            }

            var mid = rightBegin - 1;
            Swap(data, begin, mid);
            return mid;
        }

        static void Swap(int[] data, int a, int b)
        {
            if (a != b)
            {
                var x = data[a];
                data[a] = data[b];
                data[b] = x;
            }
        }
    }
}
