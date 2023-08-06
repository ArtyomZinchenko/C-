// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Here I generate the random square array I
int[,] arraySquareOne = CreateRandMatrix(4, 2, 0, 10); // Use int values for min and max
System.Console.WriteLine("Here is the first matrix: ");
PrintMatrix(arraySquareOne); 

// Here I generate the random square array II
int[,] arraySquareTwo = CreateRandMatrix(3, 4, 0, 10); // Use int values for min and max
System.Console.WriteLine("Here is the second matrix: ");
PrintMatrix(arraySquareTwo); 

int[,] resultMatrixMultiplication = MultiplyMatrices(arraySquareOne, arraySquareTwo);
System.Console.WriteLine("Here is the dot product of two matrixes: ");
PrintMatrix(resultMatrixMultiplication); 


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


// Function that multiples matrixes
int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    // Let's first check if the multiplication is at all possible
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        throw new ArgumentException("The number of columns in the first matrix must equal the number of rows in the second matrix.");
    }

    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }

    return result;
}
