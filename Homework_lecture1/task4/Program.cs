// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Insert the first integer: ");
int a = int.Parse(Console.ReadLine());

// int count = 0;

//Console.WriteLine("Even numbers from 1 till " + a + ":");

//for (int i = 1; i <= a; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}

// A different option I somehow like more, but the for-loop above works as well.
int count = 0;

while (count < a)
{

    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
count++;
}



