// 5 Написать программу-калькулятор. Пользователь вводит два числа и выбирает арифметическое действие. 
// Вывести на экран результат.


Console.Write("Insert the first value: ");
double.TryParse(Console.ReadLine(), out double insertedNum1);

Console.Write("Insert the second value: ");
double.TryParse(Console.ReadLine(), out double insertedNum2);

Console.WriteLine("Pick the action:");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");

int.TryParse(Console.ReadLine(), out int choice);

double result = 0;

if (choice == 1)
{
    result = insertedNum1 + insertedNum2;
}
else if (choice == 2)
{
    result = insertedNum1 - insertedNum2;
}
else if (choice == 3)
{
    result = insertedNum1 * insertedNum2;
}
else if (choice == 4)
{
    if (insertedNum2 != 0)
    {
        result = insertedNum1 / insertedNum2;
    }
    else
    {
        Console.WriteLine("Can't divide by 0!!");
        return;
    }
}
else
{
    Console.WriteLine("Wrong selection.");
    return;
}

Console.WriteLine($"Result: {result}");