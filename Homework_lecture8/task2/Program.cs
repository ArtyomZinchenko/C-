
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int result = SumNumbersInRange(1, 20);
System.Console.WriteLine($"The resulting sum is {result}");

int SumNumbersInRange(int M, int N)
{
    if (M == N) return M; // if M equals N, return M
    if (M > N) return M + SumNumbersInRange(M - 1, N); // if M is greater than N, decrement M
    return M + SumNumbersInRange(M + 1, N); // if M is less than N, increment M
}
