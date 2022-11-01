using System;
using Rect;

namespace Square
{
    public class Square:Rect.Rect
    {
        double size;
        
        public double Size { get => size; set => size = value; }

        public Square()
        {
            Size = 0;
            Name = "Квадрат";
        }
        public Square(double size):base(size,size)
        {
            Name = "Квадрат";
        }

    }
}