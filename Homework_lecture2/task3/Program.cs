// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Get the day of the week from user
Console.Write("Enter a number representing a day of the week: ");
// Parse it into a numerical value
int dayOfWeek = int.Parse(Console.ReadLine());

// use the function I defined below
bool isWeekend = IsWeekend(dayOfWeek);

// provide the response based on the isWeekend
if (Validate(dayOfWeek))
{
    if (isWeekend)
    {
        Console.WriteLine("Yes, it's a weekend day!");
    }
    else
    {
        Console.WriteLine("No, it's not a weekend day.");
    }
}
else 
{
     Console.WriteLine($"Wrong input! {dayOfWeek} is not day of the week! Restrict your selection to first 7 digits above 0!");
}


// Here is the function. It returns 1 = YES, weekend, and 0 = NO, not a weekend. This output is used above to Console.Write the correct reponse
bool IsWeekend(int dayOfWeek)
{
    return dayOfWeek == 6 || dayOfWeek == 7;
}

bool Validate(int dayOfWeek)
{
    return dayOfWeek>0 && dayOfWeek < 8;

}
