// 7
// Пользователь вводит четырехзначное число. Необходимо поменять в этом числе 1 и 2 цифры, а также 3 и 4 цифры. 
// Если пользователь вводит не четырехзначное число — вывести сообщение об ошибке.

Console.Write("Insert a four-digits number: ");
string input = Console.ReadLine();

if (input.Length != 4)
{
    Console.WriteLine("Error: It should be a 4-digits number.");
}

if (int.TryParse(input, out int number))
{
    int digit1 = int.Parse(input[0].ToString());
    int digit2 = int.Parse(input[1].ToString());
    int digit3 = int.Parse(input[2].ToString());
    int digit4 = int.Parse(input[3].ToString());

    int newNumber = digit2 * 1000 + digit1 * 100 + digit4 * 10 + digit3;

    Console.WriteLine($"New number with swapped digits: {newNumber}");
}
else
{
    Console.WriteLine("Error: It should be a 4-digits NUMBER.");
}