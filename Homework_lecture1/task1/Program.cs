// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


Console.WriteLine("Insert the first integer: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Insert the second integer: ");
int b = int.Parse(Console.ReadLine());

int max = a;
int min = b;

if (a > max)
{
    max = a;
    min = b;
}

if (b > max)
{
    max = b; min = a;
}

Console.WriteLine("The larger number is " + max);
Console.WriteLine("The smaller number is " + min);



