
using System;
using PointNamespace;

namespace PointNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();

            Console.WriteLine("Enter data for point 1:");
            point1.InputData();

            Console.WriteLine("\nData for point 1:");
            point1.OutputData();
            // Point point2 = new Point{ X = 1, Y = 2, Z = 3 };
            Point point2 = new Point(point1.X, point1.Y, point1.Z);

            Console.WriteLine("\nData for point 2:");
            point2.OutputData();
        }
    }
}