namespace GenericClass
{
    using System;

    public class GenericList<T>
    {
        private const int GrowCoefficient = 2;

        private int capacity;
        private T[] items;

        public GenericList(int capacity)
        {
            this.Capacity = capacity;
            this.Count = 0;
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
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(); // TODO:
                }

                this.capacity = value;
            }
        }

        public int Count { get; private set; }

        public T this[int index]
        {
            get
            {
                return this.items[index];
            }
            set
            {
                this.items[index] = value;
            }
        }

        public void Add(T item)
        {
            this.items[this.Count] = item;
            this.Count++;

            if (this.Count == this.Capacity)
            {
                this.ResizeItemsCollection();
            }
        }

        public void RemoveAt(int index)
        {
            for (int position = index; position < this.Count; position++)
            {
                this.items[position] = this.items[position + 1];
            }

            this.Count--;
        }

        public void InsertAt(int index, T item)
        {
            for (int position = this.Count + 1; position > index; position--)
            {
                //this.items[position] = 
            }
        }

        public void Clear()
        {
            this.Count = 0;
            this.items = new T[this.Capacity];
        }

        public T IndexOf()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return string.Join(", ", this.items) + "\nCapacity: " + this.capacity + "\nCount: " + this.Count;
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