using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplab_8
{
    
        public struct Fraction
        {
            public int numerator;
            public int denominator;

            
            public Fraction(int numerator, int denominator)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }

           
            private void Simplify()
            {
                int gcd = GCD(numerator, denominator);
                numerator /= gcd;
                denominator /= gcd;
            }

           //НСК
            private int GCD(int a, int b)
            {
                if (b == 0)
                {
                    return a;
                }
                else
                {
                    return GCD(b, a % b);
                }
            }

            // +
            public static Fraction operator +(Fraction fraction1, Fraction fraction2)
            {
                int numerator = fraction1.numerator * fraction2.denominator + fraction2.numerator * fraction1.denominator;
                int denominator = fraction1.denominator * fraction2.denominator;
                Fraction result = new Fraction(numerator, denominator);
                result.Simplify();
                return result;
            }

            // -
            public static Fraction operator -(Fraction fraction1, Fraction fraction2)
            {
                int numerator = fraction1.numerator * fraction2.denominator - fraction2.numerator * fraction1.denominator;
                int denominator = fraction1.denominator * fraction2.denominator;
                Fraction result = new Fraction(numerator, denominator);
                result.Simplify();
                return result;
            }

            // *
            public static Fraction operator *(Fraction fraction1, Fraction fraction2)
            {
                int numerator = fraction1.numerator * fraction2.numerator;
                int denominator = fraction1.denominator * fraction2.denominator;
                Fraction result = new Fraction(numerator, denominator);
                result.Simplify();
                return result;
            }

            // /
            public static Fraction operator /(Fraction fraction1, Fraction fraction2)
            {
                int numerator = fraction1.numerator * fraction2.denominator;
                int denominator = fraction1.denominator * fraction2.numerator;
                Fraction result = new Fraction(numerator, denominator);
                result.Simplify();
                return result;
            }

            // перевантаження виведення
            public override string ToString()
            {
                return numerator + "/" + denominator;
            }
        }

    
}
