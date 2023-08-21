using System;

Console.WriteLine("Введите начало диапазона: ");
int.TryParse(Console.ReadLine(), out var startOfRange);

Console.WriteLine("Введите конец диапазона: ");
int.TryParse(Console.ReadLine(), out var endOfRange);

if(startOfRange > endOfRange){
    
    startOfRange = startOfRange
    endOfRange = startOfRange;
    
}

int sum = 0;
for(int i = startOfRange; i <= endOfRange; i++)
{
    sum += i;
}

Console.WriteLine($"The sum is {sum}");