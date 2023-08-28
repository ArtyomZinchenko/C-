// Попробуйте написать программу "Быки и коровы".  Программа загадывает четырехзначное число с неповторяющимися цифрами. 
// Вы начинаете его угадывать. После каждой попытки программа сообщает подсказку - количество быков и коров. 
// Быки - это правильная цифра на правильном месте, коровы - правильные цифры на неправильном месте.
// Например, загадано число 1234, а вы ввели 1243, значит у нас 2 быка (1,2) и две коровы (3,4)
// Программа должна предусматривать показ статистики (кол-во попыток и время, затраченное на игру), а также выход по нулю, 
// если пользователю надоест угадывать

using System.Diagnostics; // for Stopwatch


static void DrawCow(string message)
{
    Console.WriteLine($"      (\"{message}\")");
    Console.WriteLine("       \\ -----------");
    Console.WriteLine("         (__)");
    Console.WriteLine("         (oo)");
    Console.WriteLine("  /------(..)");
    Console.WriteLine(" /-------|//");
    Console.WriteLine("/---------");
    Console.WriteLine("|  ||    ||");
    Console.WriteLine("^  ||----||");
    Console.WriteLine("   ^^    ^^");
}

static void ExplainRules()
{
    string message = "Guess the 4-digit number. Bulls are correct digits in correct places.\nCows are correct digits in wrong places. Enter 0 to exit.";
    DrawCow(message);
}

static int[] GenerateTarget(int size)
{
    int[] uniqueNumbers = new int[size];
    int uniqueCount = 0;
    Random rand = new Random();
    while (uniqueCount < size)
    {
        int num = rand.Next(1, 10);
        bool isUnique = true;
        for (int i = 0; i < uniqueCount; i++)
        {
            if (uniqueNumbers[i] == num)
            {
                isUnique = false;
                break;
            }
        }
        if (isUnique)
        {
            uniqueNumbers[uniqueCount] = num;
            uniqueCount++;
        }
    }
    return uniqueNumbers;
}

static (int Bulls, int Cows) CalculateBullsAndCows(int[] target, int[] guess)
{
    int bulls = 0, cows = 0; // Malvina and Buratino style :)
    for (int i = 0; i < 4; i++)
    {
        for (int j = 0; j <=i; j++)
        {
            if (target[i] == guess[j] && i == j)
            {
                bulls++;
            }
            else if (target[i] == guess[j] && i != j)
            {
                cows++;
            }
        }
    }
    return (Bulls: bulls, Cows: cows);
}

static int[] ParseGuess(int number)
{
    int[] guess = new int[4];
    for (int i = 3; i >= 0; i--)
    {
        guess[i] = number % 10;
        number /= 10;
    }
    return guess;
}

Stopwatch stopwatch = new Stopwatch();
int attempts = 0;

Console.WriteLine("----------------------- Welcome to the 'Bulls and Cows' game! -----------------------\n\n");
ExplainRules();

int[] target = GenerateTarget(4);

Console.WriteLine("To exit, enter 0.");
stopwatch.Start();

while (true)
{
    Console.Clear();
    DrawCow("Enter your guess: ");
    string input = Console.ReadLine();
    
    if (input == "0")
    {
        Console.WriteLine($"Game over. You made {attempts} attempts.");
        break;
    }
    attempts++;
    int.TryParse(input, out var number);
    if (number < 1000 || number > 9999)
    {
        Console.WriteLine("Incorrect input\nPress any key to continue");
        Console.ReadKey();
        continue;
    }
    
    int[] guess = ParseGuess(number);
    
    var result = CalculateBullsAndCows(target, guess);
    Console.WriteLine($"Bulls: {result.Bulls}, Cows: {result.Cows}");
    
    if (result.Bulls == 4)
    {
        stopwatch.Stop();
        Console.WriteLine($"Congratulations! You've guessed the number {string.Join("", target)} in {attempts} attempts.");
        break;
    }
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
}
Console.WriteLine($"Time spent on the game: {Math.Ceiling(stopwatch.Elapsed.TotalSeconds)} seconds.");