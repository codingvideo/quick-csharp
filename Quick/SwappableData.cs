using System;
namespace Quick
{
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

        public void Swap(int a, int b)
        {
            if (a != b)
            {
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
