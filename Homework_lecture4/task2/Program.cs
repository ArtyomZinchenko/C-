// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Just as in the previous task, just create an array filled with random values
// This time I will decide myself that there would be 10 random values

Random rand = new Random();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 100); // Generates a random number between -100 and 100.
}

// Print out the array
System.Console.WriteLine(String.Join(", ", array));

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)  // Check if the position is odd.
    {
        sum += array[i];
    }
}
Console.WriteLine($"The sum of the elements at odd positions is {sum}");