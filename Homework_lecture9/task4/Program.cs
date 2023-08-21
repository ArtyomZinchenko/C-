// 4 Пользователь вводит с клавиатуры объем одного фильма в гигабайтах. 
// Посчитать, сколько дискет (1,44 MB) понадобится пользователю для переноса фильма от друга к себе домой.

double megabytesPerFloppy = 1.44; // The size of the floppy in MB

Console.Write("Введите объем фильма в гигабайтах: ");
double.TryParse(Console.ReadLine(), out double movieSizeInGigabytes);

double movieSizeInMegabytes = movieSizeInGigabytes * 1024; // Convert GB into MB
double numberOfFloppyDisks = Math.Ceiling(movieSizeInMegabytes / megabytesPerFloppy); // round up

Console.WriteLine($"Для переноса фильма потребуется {numberOfFloppyDisks} дискет(ы).");
