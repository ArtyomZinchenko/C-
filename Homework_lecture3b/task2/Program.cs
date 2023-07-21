// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Please insert a single number:");
System.Console.Write("Number: ");
int Number = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine($"The sum of individual digits in the inserted number is {SumFromNum(Number) }");

// do not know yet what "statis" means but visual studio code returned a warning if I didi not use it
static int SumFromNum(int number)
{

    // This variable will store the sum of digits
    int sumOfDigits = 0;

    // WE will now oop through each digit in the number
    while (number > 0)
    {
        // Modulo will get me the last digit of the number (%)
        int digit = number % 10;

        // Add the digit to the sum
        sumOfDigits = sumOfDigits + digit;

        // Step 5: Remove the last digit from the number using integer division (//)
        number = number / 10;
    }

    // Step 6: Return the sum of digits
    return sumOfDigits;

}

