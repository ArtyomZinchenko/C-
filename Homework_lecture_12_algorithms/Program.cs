// Learning algorithms; Speaking about classification of difficulty of algorithms (O(n); O(log2(n))
//





Console.Clear();
Console.Write("Insert a number: ");
int n = int.Parse(Console.ReadLine()!); // Exclamation mark removes the warning about Null

Console.WriteLine("You entered number: ", n);
int result = 0;

for (int i = 1; i <= n; i++) //o(n) difficulty = linear algorithm
{
    result += i;
}
Console.WriteLine($"The sum of numbers from 1 till {n} equals {result}");