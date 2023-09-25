using System;
using System.Runtime.Intrinsics.X86;

namespace PointNamespace
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point(double x = 0, double y = 0, double z = 0) => (X, Y, Z) = (x, y, z);
        public void OutputData()
        {
            Console.WriteLine($"Point coordinates are: x = {X}, y = {Y}, z = {Z}");
        }
    }
}