using System;
using System.Text;

namespace MatrixClass
{
    public class Matrix
    {
        private int rows;
        private int columns;
        private int[,] structure;

        public Matrix(int[,] array)
        {
            this.structure = array;
            this.Rows = array.GetLength(0);
            this.Columns = array.GetLength(1);
        }

        public Matrix(int rows, int columns)
        {
            this.structure = new int[rows, columns];
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
                if (value <= 0)
                {
                    throw new ArgumentException("Matrix rows cannot be negative or zero value");
                }

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
                if (value <= 0)
                {
                    throw new ArgumentException("Matrix columns cannot be negative or zero value");
                }

                this.columns = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.structure.GetLength(0); row++)
            {
                for (int col = 0; col < this.structure.GetLength(1); col++)
                {
                    result.AppendFormat("{0,4}", this.structure[row, col]);
                }
                result.AppendLine();
            }

            return result.ToString();
        }

        public int this[int row, int column]
        {
            get
            {
                return this.structure[row, column];
            }
            set
            {
                this.structure[row, column] = value;
            }
        }

        public static Matrix operator +(Matrix first, Matrix second)
        {
            if (first.Rows != second.Rows && first.Columns != second.Columns)
            {
                throw new ArgumentException("The matrices are not the same size");
            }

            Matrix result = new Matrix(first.Rows, second.Columns);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < second.Columns; col++)
                {
                    result[row, col] = first[row, col] + second[row, col];
                }
            }

            return result;
        }

        public static Matrix operator -(Matrix first, Matrix second)
        {
            if (first.Rows != second.Rows && first.Columns != second.Columns)
            {
                throw new ArgumentException("The matrices are not the same size");
            }

            Matrix result = new Matrix(first.Rows, second.Columns);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < second.Columns; col++)
                {
                    result[row, col] = first[row, col] - second[row, col];
                }
            }

            return result;
        }

        public static Matrix operator *(Matrix first, Matrix second)
        {
            if (first.Rows != second.Columns)
            {
                throw new ArgumentException("First matrix rows are not equal to second matrix columns");
            }

            Matrix result = new Matrix(first.Rows, second.Columns);

            for (int row = 0; row < first.Rows; row++)
            {
                for (int col = 0; col < second.Columns; col++)
                {
                    for (int inner = 0; inner < first.Columns; inner++)
                    {
                        result[row, col] += first[row, inner] * second[inner, col];
                    }
                }
            }

            return result;
        }
    }
}