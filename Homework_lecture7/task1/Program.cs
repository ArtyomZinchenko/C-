
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Here I generate the random 2d array
int[,] array2d = CreateRandMatrix(4, 4, -100, 100); // Use int values for min and max

// Print the original array
Console.WriteLine("Original Array:");
PrintMatrix(array2d); 

// Sort the array in descending order
SortRowsDescending(array2d); // Sort the rows of the copied array

// Print the sorted array
Console.WriteLine("\nSorted Array:");
PrintMatrix(array2d); // Print the original array

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

void SortRowsDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    // Swap the elements if they are in the wrong order
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}