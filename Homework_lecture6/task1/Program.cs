// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] array2d = CreateRandMatrix(3, 4, -100.0, 100.0); // Use double values for min and max
PrintMatrix(array2d);

double[,] CreateRandMatrix(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns]; // Use double instead of int for the matrix

    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            // Generate a random double value between min (inclusive) and max (exclusive)
            matrix[i, j] = min + (rand.NextDouble() * (max - min));
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix) // Change the parameter type to double[,]
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.Write("[  ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j],8:F2}"); // Print the double values with 2 decimal places
        }
        System.Console.WriteLine("  ]");
    }
}

