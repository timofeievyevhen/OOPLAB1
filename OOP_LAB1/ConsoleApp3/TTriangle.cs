using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class TTriangle
    {
        protected double a;
        protected double b;
        protected double c;

        public TTriangle(double a, double b, double c)
        {
            if (!isTriangle(a, b, c))
            {
                throw new ArgumentException("Такого трикутника не існує");
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        protected static bool isTriangle(double sideA, double sideB, double sideC)
        {
            return sideA > 0 && sideB > 0 && sideC > 0 && (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }


        public double getA()
        {
            return a;
        }
        public double getB()
        {
            return b;
        }
        public double getC()
        {
            return c;
        }

        public void setA(double newA)
        {
            if (!isTriangle(newA, b, c))
            {
                throw new ArgumentException("Не можливо встановити сторону А, бо такого трикутника не існує");
            }
            a = newA;
        }

        public void setB(double newB)
        {
            if (!isTriangle(a, newB, c))
            {
                throw new ArgumentException("Не можливо встановити сторону В, бо такого трикутника не існує");
            }
            b = newB;
        }

        public void setC(double newC)
        {
            if (!isTriangle(a, b, newC))
            {
                throw new ArgumentException("Не можливо встановити сторону С, бо такого трикутника не існує");
            }
            c = newC;
        }
        public double getPerimeter()
        {
            return a + b + c;
        }

        public double getArea()
        {
            double p = getPerimeter() / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
