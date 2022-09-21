using System;

namespace Program
{
    public class Angle
    {
        int angles;
        float minutes;
         char napravlenie; 

        

        public Angle()
        {
            angles = 0;
            minutes = 0;
            napravlenie = 'S';
        }

        public Angle(int angles, float minutes, char napravlenie)
        {
            this.angles = angles;
            this.minutes= minutes;
            this.napravlenie= napravlenie;
        }

        public void EnterCoords()
        {
            try{
                
                System.Console.Write("Enter angles here: ");
                int.TryParse(Console.ReadLine(), out angles);
                System.Console.Write("Enter minutes here: ");
                float.TryParse(Console.ReadLine(), out  minutes);
                System.Console.Write("Enter napravlenie here: ");
                char.TryParse(Console.ReadLine(), out napravlenie);

            }
            catch
            {
                System.Console.WriteLine("error");
            }

        }
        public override string ToString()
        {
            return $"angle: {angles}\nminutes: {minutes}\nnapravlenie: {napravlenie}";
        }
    }

    public class Lab_4
    {
        public static void Main()
        {
            Angle a = new Angle(12,10,'S');
            System.Console.WriteLine(a);

            Angle b = new Angle();
            b.EnterCoords();
            System.Console.WriteLine(b);


        }
    }
}