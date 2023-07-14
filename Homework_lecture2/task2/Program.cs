// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// get random number (it may not be 3 or 2 digits only, any number would work with this code)
int Number = new Random().Next(1,100000);

// Ok, let us see the that random number
Console.WriteLine($"The random number is {Number}");

// run the function I defined below and print out the result
int thirdDigit = ThirdDigit(Number);

// Here is the function. Instead of using mathematical operations as we did during the seminar meetin
// I have decided to convert the num into a string and access it's third character and then convert that 
// character back into num. I do not know whether this operation is more computationally demanding
// relative to math operations, but it does make the code look neater relative to the example on geekbrains' page.
int ThirdDigit(int num)
{
    string text = num.ToString();

    if (text.Length < 3)
    {
        Console.WriteLine("There is no third digit!");
        return -1; 
    }
    else
    {
        Console.WriteLine($"The third digit is {int.Parse(text.Substring(2, 1))}");
        return int.Parse(text.Substring(2, 1));
        
    }
}





