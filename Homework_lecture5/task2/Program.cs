// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Let's get users' coordinates
Console.Write("Enter the value of b1: ");
double b1 = double.Parse(Console.ReadLine());

Console.Write("Enter the value of k1: ");
double k1 = double.Parse(Console.ReadLine());

Console.Write("Enter the value of b2: ");
double b2 = double.Parse(Console.ReadLine());

Console.Write("Enter the value of k2: ");
double k2 = double.Parse(Console.ReadLine());

// Calculate the intersection point (x, y)
double x, y;
FindIntersectionPoint(b1, k1, b2, k2, out x, out y);

// Display the intersection point
Console.WriteLine($"The intersection point is: ({x}; {y})");

// The function should compute the intersection point (x and y)
void FindIntersectionPoint(double b1, double k1, double b2, double k2, out double x, out double y)
{
    // Calculate the intersection point (x, y)
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}
