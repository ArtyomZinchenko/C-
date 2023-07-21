// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


// Define the array with 8 elements
int[] array = { 1, 2, 5, 7, 19, 6, 1, 33 };

// Output the array on the screen
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i < array.Length - 1)
    {
        Console.Write(", ");
    }
}

Console.Write("]");

