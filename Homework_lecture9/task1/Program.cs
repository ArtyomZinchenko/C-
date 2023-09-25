// 1 Написать программу, которая преобразует введенное пользователем количество дней в количество полных недель и оставшихся дней. Например, пользователь ввел 17 дней, программа должна вывести на экран 2 недели и 3 дня.

Console.WriteLine("Please, instert number of days: ");

int.TryParse(Console.ReadLine(), out int totalDays);

Console.WriteLine($"Полных недель: {totalDays / 7} Оставшихся дней: {totalDays % 7}");
