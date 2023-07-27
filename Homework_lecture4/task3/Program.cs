// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


// Create an instance of Random class
Random rand = new Random();

// Initialize an array of size 20
double[] array = new double[20];

// Fill the array with random numbers between -100 and 100
for (int i = 0; i < array.Length; i++)
{
    // Generate a random number between -100 and 100
    array[i] = rand.Next(-100, 101) + rand.NextDouble();
    array[i] = Math.Round(array[i], 2);
}

// Initialize max and min with the first element of the array
double max = array[0];
double min = array[0];

// Iterate over the array
for (int i = 1; i < array.Length; i++)
{
    // If the current element is greater than max, update max
    if (array[i] > max)
    {
        max = array[i];
    }

    // If the current element is less than min, update min
    if (array[i] < min)
    {
        min = array[i];
    }
}

// Print out the array
System.Console.WriteLine(String.Join(", ", array));

// Print max and min
System.Console.WriteLine($"The maximum number is {max}");
System.Console.WriteLine($"The minimum number is {min}");

// Calculate the difference
double difference = max - min;

// Print the difference
System.Console.WriteLine($"The difference between the maximum and minimum elements is {difference}");