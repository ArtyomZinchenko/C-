// 2 Написать программу, которая преобразует введенное с клавиатуры дробное число в денежный формат. 
// Например, число 12,5 должно быть преобразовано к виду 12 грн 50 коп.

Console.WriteLine("Insert a boolean number: ");

if (double.TryParse(Console.ReadLine(), out double monetaryValue))
{
    int hryvna = (int)monetaryValue;
    int kopecks = (int)((monetaryValue - hryvna) * 100);

    Console.WriteLine($"{hryvna} грн {kopecks} коп.");
}
else
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
}

