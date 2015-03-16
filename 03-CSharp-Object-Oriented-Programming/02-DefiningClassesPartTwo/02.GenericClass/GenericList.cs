namespace GenericClass
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class GenericList<T> : IEnumerable<T> where T : IComparable
    {
        private const string CapacityMinimumValueErrorMessage = "Non-negative number required";
        private const string IndexOutOfRangeErrorMessage = "Index was out of range. Must be non-negative and less than the size of the collection";
        private const string ToStringItemsSeparator = ", ";
        private const int CapacityMinimumValue = 0;
        private const int DefaultInitialCapacity = 4;
        private const int InitialItemsCount = 0;
        private const int GrowCoefficient = 2;

        private int capacity;
        private T[] items;

        public GenericList() : this(GenericList<T>.DefaultInitialCapacity) { }

        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            this.Count = GenericList<T>.InitialItemsCount;
            this.items = new T[this.Capacity];
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value < CapacityMinimumValue)
                {
                    throw new ArgumentOutOfRangeException("capacity", GenericList<T>.CapacityMinimumValueErrorMessage);
                }

                this.capacity = value;
            }
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                this.ValidateIndex(index);

                return this.items[index];
            }
            set
            {
                this.ValidateIndex(index);

                this.items[index] = value;
            }
        }

        public void Add(T item)
        {
            if (this.Count == this.Capacity)
            {
                this.ResizeItemsCollection();
            }

            this.items[this.Count] = item;
            this.Count++;
        }

        public void RemoveAt(int index)
        {
            this.ValidateIndex(index);

            for (int position = index; position < this.Count - 1; position++)
            {
                this.items[position] = this.items[position + 1];
            }

            this.items[this.Count - 1] = default(T);
            this.Count--;
        }

        public void InsertAt(int index, T item)
        {
            if (this.Count == this.Capacity)
            {
                this.ResizeItemsCollection();
            }

            for (int position = this.Count + 1; position > index; position--)
            {
                this.items[position] = this.items[position - 1];
            }

            this.items[index] = item;
            this.Count++;
        }

        public void Clear()
        {
            this.Capacity = GenericList<T>.DefaultInitialCapacity;
            this.Count = GenericList<T>.InitialItemsCount;
            this.items = new T[this.Capacity];
        }

        public T Min()
        {
            int index = 0;

            T min = this.items[index];

            for (; index < this.Count; index++)
            {
                if (this.items[index].CompareTo(min) < 0)
                {
                    min = this.items[index];
                }
            }

            return min;
        }

        public T Max()
        {
            int index = 0;

            T max = this.items[index];

            for (; index < this.Count; index++)
            {
                if (this.items[index].CompareTo(max) > 0)
                {
                    max = this.items[index];
                }
            }

            return max;
        }

        public int IndexOf(T item)
        {
            for (int index = 0; index < this.Count; index++)
            {
                if (this.items[index].CompareTo(item) == 0)
                {
                    return index;
                }
            }

            return -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int item = 0; item < this.Count; item++)
            {
                yield return items[item];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int item = 0; item < this.Count; item++)
            {
                result.Append(this.items[item]);

                if (item < this.Count - 1)
                {
                    result.Append(GenericList<T>.ToStringItemsSeparator);
                }
            }

            return result.ToString();
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("index", GenericList<T>.IndexOutOfRangeErrorMessage);
            }
        }

        private void ResizeItemsCollection()
        {
            this.Capacity *= GrowCoefficient;

            T[] newItems = new T[this.Capacity];

            Array.Copy(this.items, newItems, this.Count);

            this.items = newItems;
        }
    }
}