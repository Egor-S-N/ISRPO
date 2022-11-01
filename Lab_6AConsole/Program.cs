using System;
using Rect;
using Circle;
using Square;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            while(true)
            {
                System.Console.Write("Укажите фигуру\n1-круг\n2-квадрат\n3-прямоугольник\n0-выход\nВаш выбор:");
                int choise;
                try
                {
                    choise = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    System.Console.WriteLine("Ошибка ввода!!!");
                    return;
                }
                if (choise == 1)
                {
                    System.Console.Write("\nВведите радиус: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Circle.Circle circle = new Circle.Circle(radius);
                    circle.calculate_perimeter();
                    circle.calculate_square();
                    System.Console.WriteLine(circle.show());
                }
                else if (choise  == 2)
                {
                    
                    System.Console.Write("\nВведите сторону: ");
                    double size = Convert.ToDouble(Console.ReadLine());
                    Square.Square square = new Square.Square(size);
                    square.calculate_perimeter();
                    square.calculate_square();
                    System.Console.WriteLine(square.show());   
                }
                else if(choise == 3)
                {
                    System.Console.Write("\nВведите перввую сторону: ");
                    double sizeA = Convert.ToDouble(Console.ReadLine());
                    System.Console.Write("\nВведите вторую сторону: ");
                    double sizeB = Convert.ToDouble(Console.ReadLine());
                    Rect.Rect rect = new Rect.Rect(sizeA,sizeB);
                    rect.calculate_perimeter();
                    rect.calculate_square();
                    System.Console.WriteLine(rect.show());
                }
                else if ((choise <=0) || (choise > 3))
                {
                    System.Console.WriteLine("Пока");
                    return;
                }
                
                System.Console.WriteLine("-----------------------------");
            }
        }
    }
}