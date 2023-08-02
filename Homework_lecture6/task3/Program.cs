// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Here I generate the random array (copied from the other task)
int[,] array2d = CreateRandMatrix(3, 4, -100, 100); // Use int values for min and max

// Print this random array to check whether the provided answer is indeed correct later on
PrintMatrix(array2d);

// Compute averages per column
double[] columnAverages = CalculateColumnAverages(array2d);

// Print averages per column
PrintColumnAverages(columnAverages); // Print the column averages

// Function that creates random matrix
int[,] CreateRandMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // Use int
    Random rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            // Generate a random int value between min (inclusive) and max (exclusive)
            matrix[i, j] = rand.Next(min, max);
        }
    }
    return matrix;
}

// Function that prints the matrix
void PrintMatrix(int[,] matrix) // Change the parameter type to double[,]
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.Write("[  ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j],7}");
        }
        System.Console.WriteLine("  ]");
    }
}

// Function that computes averages per column of the matrix
double[] CalculateColumnAverages(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    double[] columnAverages = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        int columnSum = 0;
        for (int i = 0; i < rows; i++)
        {
            columnSum += matrix[i, j];
        }
        columnAverages[j] = columnSum / rows;
    }

    return columnAverages;
}

// Function to finally print out the averages
void PrintColumnAverages(double[] columnAverages)
    {
    System.Console.Write("Column Averages: ");
    for (int j = 0; j < columnAverages.Length; j++)
    {
        System.Console.Write($"{columnAverages[j]:F1}");
        if (j < columnAverages.Length - 1)
        {
            System.Console.Write("; ");
        }
    }
}