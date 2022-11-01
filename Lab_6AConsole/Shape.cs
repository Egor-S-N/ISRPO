using System;

namespace Shape
{
    public class Shape{
        private double square;
        private double perimeter;
        private string name = "";

        public Shape(){
            Square = 0;
            Perimeter = 0;
            Name = "без названия";
        }

        public double Square { get => square; set => square = value; }
        public double Perimeter { get => perimeter; set => perimeter = value; }
        public string Name { get => name; set => name = value; }

        public string show()
        {
            return $"Площадь: {Square}\nПериметр: {Perimeter}\nНазвание: {Name}";
        }
    }
}