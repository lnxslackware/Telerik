using System;
using System.Collections.Generic;

namespace BitArray64
{
    public class BitArray64 : IEnumerable<int>
    {
        private ulong holder;
        private const int MaxCount = 64;

        public BitArray64(ulong number)
        {
            this.Holder = number;
        }

        private int GetBit(int position)
        {
            int mask = 1;

            return (int)(((ulong)(mask << position) & this.Holder) >> position);
        }

        private void SetBit(int index, int bitValue)
        {
            if (GetBit(index) == bitValue)
            {
                return;
            }

            int mask = 1;
            int result = (mask << index);
            this.Holder = (uint)result ^ this.Holder;
        }

        private ulong Holder
        {
            get
            {
                return this.holder;
            }
            set
            {
                this.holder = value;
            }
        }

        public int this[int index]
        {
            get
            {
                if (index > 63 || index < 0)
                {
                    throw new IndexOutOfRangeException("The selected index must be between 0 and 63");
                }

                return this.GetBit(index);
            }
            set
            {
                if (index > 63 || index < 0)
                {
                    throw new IndexOutOfRangeException("The selected index must be between 0 and 63");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException("The passed value must be either 0 or 1");
                }

                SetBit(index, value);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < MaxCount; i++)
            {
                yield return this.GetBit(i);
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is BitArray64))
            {
                return false;
            }

            if (this.Holder != ((BitArray64)obj).Holder)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return (int)(this.Holder / 2);
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            if (first.Equals(second))
            {
                return true;
            }

            return false;
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(first == second);
        }
    }
}
