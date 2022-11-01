using System;
using Shape;

namespace Rect
{
    public class Rect: Shape.Shape{
        private double sizeA,sizeB;

        public double SizeA { get => sizeA; set => sizeA = value; }
        public double SizeB { get => sizeB; set => sizeB = value; }

        public Rect():base()
        {
            SizeA = 0;
            SizeB = 0;
            Name = "Прямоугольник";
        }

        public Rect(double sizeA, double sizeB )
        {
            SizeA = sizeA;
            SizeB = sizeB; 
            Name = "Прямоугольник";           
        }

        public void calculate_square()
        {
            Square =  SizeA * SizeB;
        }
        public void calculate_perimeter()
        {
            Perimeter = (2 * SizeA) + (2 * SizeB);
        }

    }
}
