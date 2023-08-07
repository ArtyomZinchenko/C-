// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int result = Ackermann(3, 2);
Console.WriteLine(result);

int Ackermann(int m, int n)
{
    // Check if m or n is negative
    if (m < 0 || n < 0)
    {
        Console.WriteLine("Both m and n must be non-negative.");
        return -999; // I return -999 to indicate an error
    }

    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else // m > 0 and n > 0
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}