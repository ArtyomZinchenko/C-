// Даны координаты поля шахматной доски x, y (целые числа, лежащие в диапазоне 1–8). 
// Учитывая, что левое нижнее поле доски (1,1) является черным, проверить истинность высказывания: «Данное поле является белым».


Console.Write("Введите координату x: ");
int.TryParse(Console.ReadLine(), out int x);

Console.Write("Введите координату y: ");
int.TryParse(Console.ReadLine(), out int y);

// Проверка на чередование белых и черных полей
bool isWhite = (x + y) % 2 == 0;

if (x <= 8 & y <= 8 & x != 0 & y != 0)
{
    if (isWhite)
    {
        Console.WriteLine("The current field is white.");
    }
    else
    {
        Console.WriteLine("The current field is black.");
    }
} else{
    Console.WriteLine("Inserted values are incorrect!");
}