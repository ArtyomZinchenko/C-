
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да



Console.WriteLine("Enter a 5 digit number:");

int inputNumer = Convert.ToInt32(Console.ReadLine());


if(IsFiveDigits(inputNumer) && IsPolyndrome(inputNumer))
{
    Console.WriteLine("This is a Polyndrome! Hurra!");
} else if (!IsFiveDigits(inputNumer))
{
    Console.WriteLine("Check the requirements! I said 5 digits number!");
} else 
{
    Console.WriteLine("Oe, this is not a Polyndrome :( ");
}


bool IsPolyndrome(int number)
{

    int digit1 = number / 10000;
    int digit2 = (number / 1000) % 10;
    int digit3 = (number / 100) % 10;
    int digit4 = (number / 10) % 10;
    int digit5 = number % 10;

    if (digit1 == digit5 && digit2 == digit4)
    {
        return true;
    }
    else
    {
        return false;
    }


}


bool IsFiveDigits(int number)
{

    int lengthNum = number.ToString().Length;

    if (lengthNum != 5)
    {
        return false;
    }
    else
    {
        return true;
    }
}




