using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class TEPiramid : TETriangle
    {
        private double height;
        public double Height
        {
            get => height;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Висота повинна бути більшою за 0");
                height = value;
            }
        }

        public TEPiramid() : base()
        {
            height = 1.0;
        }
        public TEPiramid(double side, double height) : base(side)
        {
            Height = height;
        }
        public TEPiramid(TEPiramid other) : base(other)
        {
            this.height = other.height;
        }
        public double getVolume()
        {
            return (1.0 / 3.0) * base.getArea() * height;
        }

        public override double getArea()
        {
            double baseArea = base.getArea();

            double r = side / (2.0 * Math.Sqrt(3));
            double apothem = Math.Sqrt(height * height + r * r);

            double sideFacesArea = 3.0 * (0.5 * side * apothem);

            return baseArea + sideFacesArea;
        }

        public override double getPerimeter()
        {
            return (3 * side) + (3*(Math.Sqrt(Math.Pow(height, 2) + Math.Pow(side, 2)/3)));
        }

        public override string ToString()
        {
            return $"Правильна трикутна піраміда: сторона основи = {side:F2}, висота = {height:F2}";
        }
        public override void input()
        {
            base.input();
            Console.Write("Введіть висоту піраміди: ");
            Height = double.Parse(Console.ReadLine() ?? "1");
        }
        public override void print()
        {
            Console.WriteLine(ToString());
        }

        public bool comparison(TEPiramid p1, TEPiramid p2)
        {
            bool sameSide = Math.Abs(p1.side - p2.side) == 0;
            bool sameHeight = Math.Abs(p1.height - p2.height) == 0;

            return sameSide && sameHeight;
        }
        public static TEPiramid operator *(TEPiramid p, double scalar)
        {
            return new TEPiramid(p.side * scalar, p.height * scalar);
        }
        public static TEPiramid operator *(double scalar, TEPiramid p)
        {
            return p * scalar;
        }
    }
}
