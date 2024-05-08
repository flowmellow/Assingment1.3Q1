// 1.Write a program in C# to calculate area of triangle, square and rectangle.
// Write 3 different functions for each shape to take dimensions of figure and display the area. You may create menus.

using System.Drawing;
using System.Security.Principal;

namespace Assingment1._3Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();          
        }

        static void Menu()
        {
            // First iteration with no user input and menu option
            //Console.WriteLine("The area of the triangle: " + AreaTriangle(5,5));
            //Console.WriteLine("The area of the rectangle is: " + AreaRectangle(2, 7));
            //Console.WriteLine("The area of the square is: " + AreaSquare(4));
            string userInput = "";

            do
            {
                Console.WriteLine("Welcome to the shape area calculator");
                Console.WriteLine("Type T to calculate the area of a Triangle");
                Console.WriteLine("Type R to calculate the area of a Rectangle");
                Console.WriteLine("Type S to calculate the area of a Square");
                Console.WriteLine("Type X to exit the program");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "T":
                    case "t":
                        Console.WriteLine("enter the triangle base number: ");
                        double triangleBase = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter the triangle base number: ");
                        double triangleHeight = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The area of the triangle: " + AreaTriangle(triangleBase, triangleHeight));
                        break;
                    case "R":
                    case "r":
                        Console.WriteLine("enter the rectangle length number: ");
                        double length = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("enter the rectangle width number: ");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The area of the rectangle is: " + AreaRectangle(length, width));
                        break;
                    case "S":
                    case "s":
                        Console.WriteLine("enter the length of a single side of the square: ");
                        double side = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("The area of the square is: " + AreaSquare(side));
                        break;
                    case "X":
                    case "x":
                        Console.WriteLine("you are now exiting the program press enter to complete");
                        break;
                }
            } while (userInput != "X" && userInput != "x");
        }

        static double AreaTriangle(double triangleBase, double triangleHeight)
        {
            //double half = 0.5;
            //double area = half * triangleBase * triangleHeight;
            //return area;
            return (triangleBase * triangleHeight) / 2;
        }
        static double AreaRectangle(double length, double width)
        {
            //double area = length * width;
            //return area;
            return length * width;
        }

        static double AreaSquare(double side)
        {
            //double area = side * side;
            //return area;
            return side * side;
        }
    }
}
