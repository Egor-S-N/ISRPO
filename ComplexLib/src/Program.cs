using System;


namespace Complex
{
    public class Complex
    {
        public Complex(double a, double b)
        {
            A = a;
            B = b;
        }
        public double A { get; set; }
        public double B { get; set; }

        public static Complex operator +(Complex first, Complex second)
        {
            return new Complex(first.A + second.A, first.B + second.B);
        }

        public static Complex operator -(Complex first, Complex second)
        {
            return new Complex(first.A - second.A, first.B - second.B);
        }

        public static Complex operator *(Complex first, Complex second)
        {
            return new Complex((first.A * second.A) - (second.B * first.B),
            (first.B * second.A) + (first.A * second.B));
        }
        public static Complex operator /(Complex first, Complex second)
        {
            return new Complex(((first.A * second.A) + (first.B * second.B)) / (Math.Pow(second.A, 2) + Math.Pow(second.B, 2)), ((first.B * second.A) - (first.A * second.B)) / (Math.Pow(second.A, 2) + Math.Pow(second.B, 2)));
        }


        public override string ToString()
        {
            if (B >= 0) return $"{A}+{B}i";
            else return $"{A}{B}i";
        }
    }
}