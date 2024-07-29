using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Square
    {
        public double side { get; set; }

        public Square(double side)
        {
            this.side = side;
        }

        public double FindSquare(double side)
        {
            double area = Math.Pow(side, 2);
            return area;
        }
    }

    public class Circle
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double FindCircle(double radius)
        {
            double circle = Math.PI * Math.Pow(radius,2);
            return circle;
        }

    }

    public class Triangle
    {
        public double Base { get; set; }
        public double height { get; set; }

        public Triangle (double Base, double Height)
        {
            this.Base = Base;
            this.height = Height;
        }

        public double FindTriangle(double Base, double Height)
        {
            double area = 0.5 * Base + Height;
            return area;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcome to Area calculator");
                Console.WriteLine("--------------------------");

                Console.WriteLine("Please select the shape you want to calculate: \n" +
                    "1.Square \n" +
                    "2.Circle \n" +
                    "3.Triangle");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("What is the length of the side?");
                        double side = Convert.ToInt32(Console.ReadLine());

                        Square square = new Square(side);
                        double area = square.FindSquare(side);

                        Console.WriteLine($"The total area of the square is {area}");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        
                        break;

                    case 2:
                        Console.WriteLine("What is the radius of the circle?");
                        double radius = Convert.ToInt32(Console.ReadLine());

                        Circle circle = new Circle(radius);
                        double C_area = circle.FindCircle(radius);

                        Console.WriteLine($"The total area of your circle is {C_area}");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        
                        break;

                    case 3:
                        Console.WriteLine("What is the base of the triangle");
                        double T_base = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the hieght of the triangle");
                        double T_Hieght = Convert.ToInt32(Console.ReadLine());

                        Triangle triangle = new Triangle(T_base, T_Hieght);
                        double T_area = triangle.FindTriangle(T_base, T_Hieght);

                        Console.WriteLine($"The total area of your triangle is {T_area}");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;


                }
            }
        }
    }
}
