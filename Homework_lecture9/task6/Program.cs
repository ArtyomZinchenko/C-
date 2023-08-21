
// 6
// Пользователь вводит с клавиатуры целое шестизначное число. Написать программу, которая определяет, 
// является ли введенное число — счастливым (Счастливым считается шестизначное число, 
// у которого сумма первых 3 цифр равна сумме вторых трех цифр).
//  Если пользователь ввел не шестизначное число — сообщение об ошибке.


Console.Write("Введите шестизначное число: ");
string input = Console.ReadLine();

if (input.Length != 6)
{
    Console.WriteLine("Ошибка: Введите шестизначное число.");
}

if (int.TryParse(input, out int number))
{
    int sumFirstThreeDigits = int.Parse(input[0].ToString()) + int.Parse(input[1].ToString()) + int.Parse(input[2].ToString());
    int sumLastThreeDigits = int.Parse(input[3].ToString()) + int.Parse(input[4].ToString()) + int.Parse(input[5].ToString());

    if (sumFirstThreeDigits == sumLastThreeDigits)
    {
        Console.WriteLine("Yep, this is a happy number. Congratulations!");
    }
    else
    {
        Console.WriteLine("Ooops, not a happy number. Sorry!.");
    }
}
else
{
    Console.WriteLine("Error. Please insert a 6-digit numer.");
}