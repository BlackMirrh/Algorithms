using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    class Complex
    {
        private double re, im;

        public double Real
        {
            get { return re; }
            set { re = value; }
        }

        public double Imaginary
        {
            get { return im; }
            set { im = value; }
        }

        // binary operator overloading
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex() { Real = c1.Real + c2.Real, Imaginary = c1.Imaginary + c2.Imaginary };
        }

        public static Complex operator -(Complex c)
        {
            return new Complex() { Real = -c.Real, Imaginary = -c.Imaginary };
        }

        // cast operator overloading (both implicit and explicit)
        public static implicit operator double(Complex c)
        {
            return Math.Sqrt(Math.Pow(c.Real, 2) + Math.Pow(c.Imaginary, 2));
        }

        public static explicit operator string(Complex c)
        {
            return c.Real.ToString() + " + " + c.Imaginary.ToString() + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex number1 = new Complex() { Real = 1, Imaginary = 2 };
            Complex number2 = new Complex() { Real = 4, Imaginary = 10 };
            Complex number3 = number1 + number2;

            number3 = -number3;
            double testNumber = number3;
            Console.WriteLine((string)number3);

            global::System.Console.WriteLine("Hello, World!");

            Console.ReadLine();
        }
    }
}
