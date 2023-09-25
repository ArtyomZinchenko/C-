// 2 Написать программу, которая преобразует введенное с клавиатуры дробное число в денежный формат. 
// Например, число 12,5 должно быть преобразовано к виду 12 грн 50 коп.

Console.WriteLine("Insert a number: ");

if (double.TryParse(Console.ReadLine(), out double monetaryValue))
{
 
     Console.WriteLine($"{(int)monetaryValue} грн {Math.Round(monetaryValue % 1 * 100)} коп.");
}
else
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
}

