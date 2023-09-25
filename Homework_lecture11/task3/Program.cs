
using System;
using PointNamespace;

namespace PointNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x coordinate: ");
            int.TryParse(Console.ReadLine(), out var x);
            Console.WriteLine("Enter y coordinate: ");
            int.TryParse(Console.ReadLine(), out var y);
            Console.WriteLine("Enter z coordinate: ");
            int.TryParse(Console.ReadLine(), out var z);
            
            Point point = new Point(x,y,z);
            point.OutputData();

            Point point2 = new();
            point2.OutputData();
        }
    }
}