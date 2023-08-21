// 1 Написать программу, которая преобразует введенное пользователем количество дней в количество полных недель и оставшихся дней. Например, пользователь ввел 17 дней, программа должна вывести на экран 2 недели и 3 дня.

Console.WriteLine("Please, instert number of days: ");

bool flag = int.TryParse(Console.ReadLine(), out int totalDays);

// int totalDays = int.Parse(Console.ReadLine());

int weeks = totalDays / 7; // количество полных недель

int remainingDays = totalDays % 7; // оставшиеся дни

Console.WriteLine($"Полных недель: {weeks}");
Console.WriteLine($"Оставшихся дней: {remainingDays}");
