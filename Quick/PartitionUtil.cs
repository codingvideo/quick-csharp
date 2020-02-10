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

        internal static int DoublePointerPartition(SwappableData data, int begin, int end)
        {
            var mid = (int) ((begin + end) / 2);
            var pivot = MedianOfThree(data[begin], data[mid], data[end]);
            var i = begin - 1;
            var j = end + 1;
            while (true)
            {
                while (true)
                {
                    i++;
                    if (data[i] >= pivot)
                    {
                        break;
                    }
                }
                while (true)
                {
                    j--;
                    if (data[j] <= pivot)
                    {
                        break;
                    }
                }
                if (i < j)
                {
                    if (data[i] != data[j])
                    {
                        data.Swap(i, j);
                    }
                }
                else
                {
                    return j;
                }
            }
        }

        static int MedianOfThree(int a, int b, int c)
        {
            if(a >= b)
                if(a <= c)
                    return a;
                else
                    if(b >= c)
                        return b;
                    else
                        return c;
            else
                if (b <= c)
                    return b;
                else
                    if (a >= c)
                        return a;
                    else
                        return c;
        }
    }
}
