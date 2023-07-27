// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// Long story short, here I ask users input a number of random number they want to have in their array 
// and store the resposes for later use.
System.Console.WriteLine("How many random 3-digit number would you like to have in your array?");
System.Console.Write("Type your answer: ");
int threeDigitsNum = Convert.ToInt32(Console.ReadLine());

// Generate an empty array
int[] array = new int[threeDigitsNum];

// Here create the ranNum (random Number) instance that we will later use below.
Random ranNum = new Random();

// Loop as many times as used defined above and randomly pick a 3-digit number
for (int i = 0; i < threeDigitsNum; i++)
{
    array[i] = ranNum.Next(100, 1000);

}

//  Here I check whether the array construction worked properly
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine(String.Join(", ", array[i]));
}


int NumEvenDigits(int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result += 1;
    }

    return result;
}

// Now assign the output of our function into the NumDig variable
int NumDig = NumEvenDigits(array);

// Print the output/ result.
System.Console.WriteLine($"There were {NumDig} even numbers in this array" );








