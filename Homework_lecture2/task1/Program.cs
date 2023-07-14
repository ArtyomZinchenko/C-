// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Get the random number
int Number = new Random().Next(100, 1000);

// print that random number so that I can check if the function works properly
System.Console.WriteLine($"The random number is {Number}");

// Use the function I defined below.
System.Console.WriteLine($"The second digit is {SecondDigit(Number)}");

// Function to extract second digit
int SecondDigit(int num)
{
    int secondDigit = (num / 10) % 10;
    return secondDigit;

}



