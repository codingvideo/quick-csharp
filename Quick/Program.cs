using System;

namespace Quick
{
    class Program
    {

        static void Main(string[] args)
        {
            var data = new SwappableData( 5, 2, 7, 4, 1, 6, 3 );
            Func<SwappableData, int, int, int> partition = PartitionUtil.BasicPartition;
            Quicksort(data, 0, data.Length-1, partition);
            Console.WriteLine(data);
        }

        static void Quicksort(SwappableData data, int begin, int end, Func<SwappableData, int, int, int> partition)
        {
            if (begin < end)
            {
                var mid = partition(data, begin, end);
                Quicksort(data, begin, mid, partition);
                Quicksort(data, mid + 1, end, partition);
            }
        }
    }
}
