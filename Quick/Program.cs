using System;

namespace Quick
{
    using PartitionStrategy = Func<SwappableData, int, int, int>;

    class Program
    {

        static void Main(string[] args)
        {
            var data = new SwappableData( 5, 2, 7, 4, 1, 6, 3 );
            PartitionStrategy partition = PartitionUtil.DoublePointerPartition;
            Quicksort(data, 0, data.Length-1, partition);
            Console.WriteLine(data);
        }

        static void Quicksort(SwappableData data, int begin, int end, PartitionStrategy partition)
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
