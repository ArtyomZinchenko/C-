// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


// Here I generate the random square array
int[,] arraySquare = CreateRandMatrix(4, 4, -100, 100); // Use int values for min and max

// Print the original array
Console.WriteLine("Original Square Array:");
PrintMatrix(arraySquare); 

// Here I compute sums per row
int[] rowSums = ComputeRowSums(arraySquare);

// And print those computed values
PrintRowSums(rowSums);

// Among those that were computed above, find the minimum Index
int minSumRowIndex = FindMinSumIndex(rowSums);

// Among those that were computed above, find the minimum Value
int minSumRowValue = FindMinSumValue(rowSums);

// Finally, print out the minimum score
Console.WriteLine($"Row with minimum sum: {minSumRowIndex + 1} and the minimum value is {minSumRowValue}");


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


// Function to Compute and return the sums of each row
int[] ComputeRowSums(int[,] matrix)
{
    int[] sumOfRows = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumOfRows[i] += matrix[i, j];
        }
    }

    return sumOfRows;
}

// Function to Print the sums
void PrintRowSums(int[] rowSums)
{
    for (int i = 0; i < rowSums.Length; i++)
    {
        Console.WriteLine($"Sum of row {i+1}: {rowSums[i]}");
    }
}


// Function to Find the minimum sum index
int FindMinSumIndex(int[] rowSums)
{
    int minSum = int.MaxValue;
    int minSumIndex = 0;

    for (int i = 0; i < rowSums.Length; i++)
    {
        if (rowSums[i] < minSum)
        {
            minSum = rowSums[i];
            minSumIndex = i;
        }
    }

    return minSumIndex;
}


// Function to Find the minimum sum value
int FindMinSumValue(int[] rowSums)
{
    int minSum = int.MaxValue; // I read that it is a good practice to set int to max possible value: int.MaxValue when finding minimum
    int minSumIndex = 0;

    for (int i = 0; i < rowSums.Length; i++)
    {
        if (rowSums[i] < minSum)
        {
            minSum = rowSums[i];
            minSumIndex = i;
        }
    }

    return minSum;
}











