using System;
using Shape;

namespace Circle
{
    public class Circle: Shape.Shape
    {
        //Пи * Р^2

        private double radius;
        private const double PI = 3.14;

        public double Radius { get => radius; set => radius = value; }

        public Circle():base()
        {
            radius = 0;
            Name = "Окружность";
        }
        public Circle(double radius)
        {
            Radius = radius;
            Name = "Окружность";
        }

        public void calculate_square()
        {
            Square = PI * Math.Pow(Radius,2);
        }

        public void calculate_perimeter()
        {
            Perimeter = 2 * PI * Radius;
        }


    }
    
}