using System;

namespace Quick
{
    class Program
    {
        static void Main(string[] args)
        {

            var data = new SwappableData( 5, 2, 7, 4, 1, 6, 3 );
            Quicksort(data, 0, data.Length-1);
            Console.WriteLine(data);
        }

        static void Quicksort(SwappableData data, int begin, int end)
        {
            if (begin < end)
            {
                var mid = Partition(data, begin, end);
                Quicksort(data, begin, mid);
                Quicksort(data, mid + 1, end);
            }
        }

        static int Partition(SwappableData data, int begin, int end)
        {
            var pivot = data[begin];
            var rightBegin = begin + 1;

            for(var i=rightBegin; i <= end; i++)
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

    class SwappableData {

        private int[] data;

        public int this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }

        public SwappableData(params int[] nums)
        {
            data = nums;
        }

        public void Swap(int a, int b) {
            if(a != b){
                var x = data[a];
                data[a] = data[b];
                data[b] = x;
            }
        }

        public override string ToString()
        { 
            return string.Join(", ", data);
        }

        public int Length
        {
            get { return data.Length; }
        }
    }
}
