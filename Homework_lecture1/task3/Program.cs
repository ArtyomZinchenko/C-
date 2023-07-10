// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Insert the first integer: ");
int a = int.Parse(Console.ReadLine());

if(a % 2 == 0) {

    Console.WriteLine("YES, this is an even number");

} else {

    Console.WriteLine("NO, this is an odd number");
}




