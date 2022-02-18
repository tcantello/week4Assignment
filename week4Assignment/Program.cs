/*
Program - week4Assignment
Programer - Toby Cantello
Date Created - 
Last Date Updated - 2/17/2022
*/


using System;

namespace week4Assignment
{
    class Program
    {
        private static Random random;
        public class Rectangle
        {
            public int width = 0;
            public int length = 0;
            public static void MakeRectangle(out int randomWidth, out int randomLength)
            {
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
        public class Utilty
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
        static void Main(string[] args)
        {
            random = new Random();

            Rectangle.MakeRectangle(out int width, out int length);
            Rectangle.NewWidth(width);
            Rectangle.NewLength(length);
            Utilty.AreaCalcuation(width, length);
            Utilty.PerimeterCalcuation(width, length);
        }
    }
}