using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Matrix
    {
        private int[,] data;
        public int rows { get; }
        public int columns { get; }

        public Matrix(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                throw new ArgumentException("Розмірність матриці потрібна більше 0");
            }

            this.rows = rows;
            this.columns = columns;
            data = new int[rows, columns];
        }

        public void input()
        {
            Console.WriteLine($"Введіть елементи для матриці {rows}x{columns}:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Елемент[{i}, {j}] = ");
                    data[i, j] = int.Parse(Console.ReadLine() ?? "0");
                }
            }
        }

        public int this[int row, int col]
        {
            get
            {
                normIndx(row, col);
                return data[row, col];
            }
            set
            {
                normIndx(row, col);
                data[row, col] = value;
            }
        }

        private void normIndx(int row, int col)
        {
            if (row < 0 || row >= rows || col < 0 || col >= columns)
            {
                throw new IndexOutOfRangeException("Не вірний індекс");
            }
        }

        public void print()
        {
            Console.WriteLine("Матриця:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{data[i, j],6} ");
                }
                Console.WriteLine();
            }
        }

        public int getMin()
        {
            int min = data[0, 0];
            foreach (int item in data)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        public int getMax()
        {
            int max = data[0, 0];
            foreach (int item in data)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
