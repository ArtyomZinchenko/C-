// Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// 0, 7, 8, -2, -2 -> 


// HEre I create a variable to keep track of the count
int countGreaterThanZero = 0;

// Read the number of inputs from the user
Console.Write("Please, indicate how many number you would like to enter: ");
int M = int.Parse(Console.ReadLine());

// Loop to take M numbers as input from the user
for (int i = 0; i < M; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    int num = int.Parse(Console.ReadLine());
    if (num > 0)
    {
        countGreaterThanZero++;
    }
}

// Display the result
Console.WriteLine($"The number of positive numbers entered is: {countGreaterThanZero}");


