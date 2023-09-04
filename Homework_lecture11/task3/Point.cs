using System;

namespace PointNamespace
{
    public class Point
    {
        private double x;
        private double y;
        private double z;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double Z { get => z; set => z = value; }

        public Point()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        public Point(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void InputData()
        {
            double value;
            string input;

            Console.Write("Enter x coordinate: ");
            input = Console.ReadLine();
            if (double.TryParse(input, out value))
            {
                X = value;
            }
            else
            {
                Console.WriteLine("Invalid input for x coordinate. Setting to 0.");
                X = 0;
            }

            Console.Write("Enter y coordinate: ");
            input = Console.ReadLine();
            if (double.TryParse(input, out value))
            {
                Y = value;
            }
            else
            {
                Console.WriteLine("Invalid input for y coordinate. Setting to 0.");
                Y = 0;
            }

            Console.Write("Enter z coordinate: ");
            input = Console.ReadLine();
            if (double.TryParse(input, out value))
            {
                Z = value;
            }
            else
            {
                Console.WriteLine("Invalid input for z coordinate. Setting to 0.");
                Z = 0;
            }
        }

        public void OutputData()
        {
            Console.WriteLine($"Point coordinates are: x = {X}, y = {Y}, z = {Z}");
        }
    }
}