// 8
// Грузовой самолет должен пролететь с грузом из пункта А в пункт С через пункт В. 
// Емкость бака для топлива у самолета — 300 литров. Потребление топлива на 1 км в зависимости от веса груза у самолета следующее:
// ¦ до 500 кг — 1 литров/км;
// ¦ до 1000 кг — 4 литров/км;
// ¦ до 1500 кг — 7 литров/км;
// ¦ до 2000 кг — 9 литров/км;
// ¦ более 2000 кг — самолет не поднимает.
// Пользователь вводит расстояние между пунктами А и В, и расстояние между пунктами В и С, а также вес груза. 
// Программа должна рассчитать какое минимальное количество топлива необходимо для дозаправки самолету в пункте В, 
// чтобы долететь из пункта А в пункт С. В случае невозможности преодолеть любое из расстояний — программа должна вывести 
// сообщение о невозможности полета по введенному маршруту.

const double fuelTankCapacity = 300; // 

// Input distances and cargo weight
Console.WriteLine("Enter the distance between point A and B (km):");
double.TryParse(Console.ReadLine(), out double distanceAB);

Console.WriteLine("Enter the distance between point B and C (km):");
double.TryParse(Console.ReadLine(), out double distanceBC);

Console.WriteLine("Enter the weight of the cargo (kg):");
double.TryParse(Console.ReadLine(), out double cargoWeight);

// Determine fuel consumption based on cargo weight
double fuelPerKm = 0;
if (cargoWeight <= 500)
    fuelPerKm = 1;
else if (cargoWeight <= 1000)
    fuelPerKm = 4;
else if (cargoWeight <= 1500)
    fuelPerKm = 7;
else if (cargoWeight <= 2000)
    fuelPerKm = 9;
else
{
    Console.WriteLine("The plane cannot lift the cargo.");
    return;
}

// Calculate the total fuel needed for both legs of the trip
double fuelRequiredAB = distanceAB * fuelPerKm;
double fuelRequiredBC = distanceBC * fuelPerKm;
double totalFuelRequired = fuelRequiredAB + fuelRequiredBC;

// Calculate the minimum fuel required for refueling at point B
double refuelingAtB = totalFuelRequired - fuelTankCapacity;

if (fuelRequiredAB > fuelTankCapacity || fuelRequiredBC > fuelTankCapacity)
{
    Console.WriteLine("The plane cannot fly the entered route due to fuel limitations.");
    return;
}

if (refuelingAtB <= 0)
    Console.WriteLine("No refueling is needed at point B.");
else
    Console.WriteLine($"The plane needs to be refueled with at least {refuelingAtB} liters at point B.");
