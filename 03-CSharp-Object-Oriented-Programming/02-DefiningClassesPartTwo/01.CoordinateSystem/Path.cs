namespace CoordinateSystem
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    [Serializable]
    public class Path : IEnumerable<Point3D>
    {
        private const string IndexOutOfRangeErrorMessage = "Index was out of range. Must be non-negative and less than the size of the collection";
        private const string ToStringPointsSeparator = ", ";

        private List<Point3D> items;

        public Path() : this(null) { }

        public Path(List<Point3D> points)
        {
            this.Points = points;
        }

        public List<Point3D> Points
        {
            get
            {
                return new List<Point3D>(this.items);
            }
            private set
            {
                if (value == null)
                {
                    this.items = new List<Point3D>();
                }
                else
                {
                    this.items = new List<Point3D>(value);
                }
            }
        }

        public int Count
        {
            get
            {
                return this.items.Count;
            }
        }

        public Point3D this[int index]
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

        public void AddPoint(Point3D point)
        {
            this.items.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.items.Remove(point);
        }

        public void RemovePointAt(int index)
        {
            this.ValidateIndex(index);

            this.items.RemoveAt(index);
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            foreach (var item in this.items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(Path.ToStringPointsSeparator, this.items);
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new ArgumentOutOfRangeException("index", Path.IndexOutOfRangeErrorMessage);
            }
        }
    }
}