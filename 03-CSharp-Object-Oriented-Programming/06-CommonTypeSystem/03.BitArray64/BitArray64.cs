namespace BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class BitArray64 : IEnumerable<int>
    {
        private const int BitsCount = 64;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number { get; private set; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = BitsCount - 1; i >= 0; i--)
            {
                yield return this[i];
            }
        }

        public override bool Equals(object obj)
        {
            BitArray64 bitArray = obj as BitArray64;

            if (bitArray == null)
            {
                return false;
            }

            if (this.GetHashCode() == bitArray.GetHashCode())
            {
                return true;
            }

            return false;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= BitsCount)
                {
                    throw new IndexOutOfRangeException("Index is out of range : [0 - 63]");
                }

                return (int)((this.Number >> index) & 1);
            }
        }

        public override int GetHashCode()
        {
            int bitShift = 17;

            return Number.GetHashCode() ^ BitsCount.GetHashCode() >> bitShift;
        }

        public override string ToString()
        {
            return string.Join("", this);
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(BitArray64.Equals(first, second));
        }
    }
}