using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplab_8
{
    public struct Complex
    {
        public double Real;
        public double Imaginary;

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
                               c1.Real * c2.Imaginary + c2.Real * c1.Imaginary);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            double denominator = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
            if (denominator == 0)
            {
                throw new DivideByZeroException();
            }
            return new Complex((c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denominator,
                               (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denominator);
        }

        public override string ToString()
        {
            if (Imaginary < 0)
            {
                return $"{Real} - {-Imaginary}i";
            }
            return $"{Real} + {Imaginary}i";
        }
    }
}
