// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 -> 
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Enter an integer: ");
int inpNum = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Table of cubic numbers from 1 till " + inpNum + ":");
Console.WriteLine("Value | Its cube");

for (int i = 1; i <= inpNum; i++)
{
    int cube = i * i * i;
    Console.WriteLine(i + "     | " + cube);
}
