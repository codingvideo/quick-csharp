using System;
namespace Quick
{
    class PartitionUtil
    {
        internal static int BasicPartition(SwappableData data, int begin, int end)
        {
            var pivot = data[begin];
            var rightBegin = begin + 1;

            for (var i = rightBegin; i <= end; i++)
            {
                if (data[i] < pivot)
                {
                    data.Swap(i, rightBegin);
                    rightBegin++;
                }
            }

            var mid = rightBegin - 1;
            data.Swap(begin, mid);
            return mid;
        }
    }
}
