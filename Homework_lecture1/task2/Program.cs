// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.WriteLine("Insert the first integer: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Insert the second integer: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Insert the third integer: ");
int c = int.Parse(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine("The largest number is " + max);


