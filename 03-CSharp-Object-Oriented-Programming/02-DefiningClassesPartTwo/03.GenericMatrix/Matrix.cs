namespace MatrixClass
{
    using System;
    using System.Text;

    public class Matrix<T> where T : struct, IComparable
    {
        private const string DimensionCellsMinimumCountErrorMessage = "Non-negative number required";
        private const string IndexOutOfRangeErrorMessage = "Index was out of range. Must be non-negative and less than the size of the collection";
        private const string DifferentMatricesSizeErrorMessage = "The matrices are not the same size";
        private const string DifferentMatricesRowsColumnsErrorMessage = "First matrix rows are not equal to second matrix columns";
        private const int RowsMinimumCount = 0;
        private const int ColumnsMinimumCount = 0;
        private const int ToStringPadding = 4;

        private int rows;
        private int columns;
        private T[,] items;

        public Matrix(T[,] matrix)
        {
            this.items = matrix;
            this.Rows = matrix.GetLength(0);
            this.Columns = matrix.GetLength(1);
        }

        public Matrix(int rows, int columns)
        {
            this.items = new T[rows, columns];
            this.Rows = rows;
            this.Columns = columns;
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                Matrix<T>.ValidateRowsCount(value);

                this.rows = value;
            }
        }

        public int Columns
        {
            get
            {
                return this.columns;
            }

            private set
            {
                Matrix<T>.ValidateColumnsCount(value);

                this.columns = value;
            }
        }

        public T this[int row, int column]
        {
            get
            {
                this.ValidateRowIndex(row);
                this.ValidateColumnIndex(column);

                return this.items[row, column];
            }
            set
            {
                this.ValidateRowIndex(row);
                this.ValidateColumnIndex(column);

                this.items[row, column] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T>.ValidateMatricesSize(first, second);

            Matrix<T> result = new Matrix<T>(first.Rows, second.Columns);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < second.Columns; col++)
                {
                    result[row, col] = (dynamic)first[row, col] + second[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            Matrix<T>.ValidateMatricesSize(first, second);

            Matrix<T> result = new Matrix<T>(first.Rows, second.Columns);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < second.Columns; col++)
                {
                    result[row, col] = (dynamic)first[row, col] - second[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            ValidateMatricesForMultiplication(first, second);

            Matrix<T> result = new Matrix<T>(first.Rows, second.Columns);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < second.Columns; col++)
                {
                    for (int inner = 0; inner < first.Columns; inner++)
                    {
                        result[row, col] += (dynamic)first[row, inner] * second[inner, col];
                    }
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Columns; col++)
                {
                    if (matrix[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Columns; col++)
                {
                    if (matrix[row, col].Equals(default(T)))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Columns; col++)
                {
                    result.Append(this.items[row, col].ToString().PadLeft(Matrix<T>.ToStringPadding));
                }

                result.AppendLine();
            }

            return result.ToString();
        }

        private void ValidateRowIndex(int row)
        {
            if (row < 0 || row >= this.items.GetLength(0))
            {
                throw new ArgumentOutOfRangeException("row", Matrix<T>.IndexOutOfRangeErrorMessage);
            }
        }

        private void ValidateColumnIndex(int column)
        {
            if (column < 0 || column >= this.items.GetLength(1))
            {
                throw new ArgumentOutOfRangeException("column", Matrix<T>.IndexOutOfRangeErrorMessage);
            }
        }

        private static void ValidateRowsCount(int value)
        {
            if (value < Matrix<T>.RowsMinimumCount)
            {
                throw new ArgumentOutOfRangeException("rows", Matrix<T>.DimensionCellsMinimumCountErrorMessage);
            }
        }

        private static void ValidateColumnsCount(int value)
        {
            if (value < Matrix<T>.ColumnsMinimumCount)
            {
                throw new ArgumentOutOfRangeException("columns", Matrix<T>.DimensionCellsMinimumCountErrorMessage);
            }
        }

        private static void ValidateMatricesSize(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Rows && first.Columns != second.Columns)
            {
                throw new ArgumentException(Matrix<T>.DifferentMatricesSizeErrorMessage);
            }
        }

        private static void ValidateMatricesForMultiplication(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Columns)
            {
                throw new ArgumentException(Matrix<T>.DifferentMatricesRowsColumnsErrorMessage);
            }
        }
    }
}