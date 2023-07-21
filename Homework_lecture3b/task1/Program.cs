// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int A = 3;
// int B = 5;

System.Console.WriteLine("Please insert the first number:");
System.Console.Write("A: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Please insert the second number:");
System.Console.Write("B: ");
int B = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(calculatePower(A, B));

double calculatePower(int A, int B) 
{
  double result = 1;
  for (int i = 1; i <= B; i++) {
    result = result * A;
  }
  return result;
}
