/*
Program - week4Assignment
Programer - Toby Cantello
Date Created - 
Last Date Updated - 3/4/2022
*/

using System;

namespace week4Assignment
{
    class Rectangle
    {
        public int width = 0;
        public int length = 0;
        public static void MakeRectangle(out int randomWidth, out int randomLength)
        {
            Random random = new Random();

            Console.WriteLine();
            Console.WriteLine("Please enter minimum width for a rectangle: ");
            int uwMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter maximum width for a rectangle: ");
            int uwMax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter minimum length for a rectangle: ");
            int ulMin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter maximum length for a rectangle: ");
            int ulMax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            randomWidth = random.Next(uwMin, uwMax);
            randomLength = random.Next(ulMin, uwMax);
        }
        public static void NewWidth(int newwidth)
        {
            Console.WriteLine("The width of your rectangle is: " + newwidth);
        }
        public static void NewLength(int newlength)
        {
            Console.WriteLine("The width of your rectangle is: " + newlength);
        }
    }
    class Utilty
    {
        public static void AreaCalcuation(int W, int L)
        {
            int area = W * L;
            Console.WriteLine("The area of your rectangle is: " + area);
        }
        public static void PerimeterCalcuation(int W, int L)
        {
            int perimeter = 2 * (W + L);
            Console.WriteLine("The perimeter of your rectangle is: " + perimeter);
        }
    }
    class Program
    {
        private static Random random;
        static void Main(string[] args)
        {
            Rectangle.MakeRectangle(out int width, out int length);
            Rectangle.NewWidth(width);
            Rectangle.NewLength(length);
            Utilty.AreaCalcuation(width, length);
            Utilty.PerimeterCalcuation(width, length);
        }
    }
}