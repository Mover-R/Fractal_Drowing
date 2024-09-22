using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractalTest
{
    internal class Complex
    {
        public double a;
        public double b;

        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Square()
        {
            double real = a * a - b * b;
            b = 2.0 * a * b;
            a = real;
        }

        public double ABS()
        {
            return Math.Sqrt(a * a + b * b);
        }
        public void Plus(Complex c) {
            a += c.a;
            b += c.b;
        }

        public void Product(double c) 
        {
            a*=c; 
            b*=c;
        }
    }
}
