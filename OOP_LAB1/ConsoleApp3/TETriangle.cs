using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class TETriangle
    {

        protected double side;

        public double Side
        {
            get => side;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Довжина сторони повинна бути більшою за 0");
                side = value;
            }
        }

        public TETriangle()
        {
            side = 1.0;
        }

        public TETriangle(double side)
        {
            Side = side;
        }

        public TETriangle(TETriangle other)
        {
            side = other.side;
        }
        public override string ToString()
        {
            return $"Рівносторонній трикутник з стороною: {side}";
        }
        public virtual void input()
        {
            Console.Write("Введіть нову довжину сторони: ");
            Side = double.Parse(Console.ReadLine() ?? "1");
        }
        public virtual void print()
        {
            Console.WriteLine(ToString());
        }

        public virtual double getArea()
        {
            return (Math.Sqrt(3) / 4.0) * side * side;
        }

        public virtual double getPerimeter()
        {
            return 3 * side;
        }

        public bool comparison(TETriangle t1, TETriangle t2)
        {
            return Math.Abs(t1.side - t2.side) == 0;
        }

        public static TETriangle operator *(TETriangle t, double num)
        {
            return new TETriangle(t.side * num);
        }

        public static TETriangle operator *(double num, TETriangle t)
        {
            return t * num;
        }
    }
}
