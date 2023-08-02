// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

// Here I generate the random array (copied from the other task)
int[,] array2d = CreateRandMatrix(3, 4, -100, 100); // Use int values for min and max

// Print this random array to check whether the provided answer is indeed correct later on
PrintMatrix(array2d);

// Now get the value that is under the provided indexes, in case if the indexes are correct, otherwise error message.
// Assign the output into the 'result' variable
string result = PrintMatrixNumPos(array2d,2,2);
// print out the 'result' to the users
System.Console.WriteLine(result);

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

// Function that finds the number given the indexes
string PrintMatrixNumPos(int[,] matrix, int i, int j) // Change the parameter type to int[,]
{
    if (i >= 0 && i < matrix.GetLength(0) && j >= 0 && j < matrix.GetLength(1))
    {
        return $"The requested indexes contain value {matrix[i, j].ToString()}";
    }
    else
    {
        return "Wrong! Provide correct array indexes";
    }
}

