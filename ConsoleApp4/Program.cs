using System;

namespace ConsoleApplab_8
{
    internal class Program
    {
        static void Main()
        {
            //1
            
            Fraction fraction1 = new Fraction(1, 2);
            Fraction fraction2 = new Fraction(3, 4);
            Console.WriteLine("Fraction 1 = "+fraction1);
            Console.WriteLine("Fraction 2 = " + fraction2);
            Fraction sum = fraction1 + fraction2;
            Fraction difference = fraction1 - fraction2;
            Fraction product = fraction1 * fraction2;
            Fraction quotient = fraction1 / fraction2;
            Console.WriteLine("Sum: " + sum + " (" + fraction1 + " + " + fraction2 + ")");
            Console.WriteLine("Difference: " + difference + " (" + fraction1 + " - " + fraction2 + ")");
            Console.WriteLine("Product: " + product + " (" + fraction1 + " * " + fraction2 + ")");
            Console.WriteLine("Quotient: " + quotient + " (" + fraction1 + " / " + fraction2 + ")");
            
            //2

            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(3, 4);
            Console.WriteLine("Complex number 1 = "+c1);
            Console.WriteLine("Complex number 2 = " + c2);
            Complex sum2 = c1 + c2;
            Complex difference2 = c1 - c2;
            Complex product2 = c1 * c2;
            Complex quotient2 = c1 / c2;

            Console.WriteLine($"Sum: {sum2}");
            Console.WriteLine($"Difference: {difference2}");
            Console.WriteLine($"Product: {product2}");
            Console.WriteLine($"Quotient: {quotient2}");
        }
    }
}