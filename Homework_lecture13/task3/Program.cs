// Создайте базовый класс Vehicle с методом Drive(), который выводит сообщение о движении транспортного средства. 
// Затем создайте производные классы, представляющие разные виды транспортных средств (например, Car, Bicycle, Boat) и 
// переопределите метод Drive() в каждом классе так, чтобы он выводил соответствующее сообщение.

Car car = new();
Bicycle bicycle = new();
Truck truck = new();
Boat boat = new();

System.Console.WriteLine(car.Drive());
System.Console.WriteLine(bicycle.Drive());
System.Console.WriteLine(truck.Drive());
System.Console.WriteLine(boat.Drive());


public abstract class Vehicle
{
    public abstract string Drive();

}

public class Car : Vehicle
{
    public string Message { get; set; }

    public override string Drive() => Message;

    public Car(string message = "80 km/ hour") => Message = message;
}

public class Bicycle : Vehicle
{
    public string Message { get; set; }

    public override string Drive() => Message;

    public Bicycle(string message = "15 km/ hour") => Message = message;


}

public class Truck : Vehicle
{
    public string Message { get; set; }

    public override string Drive() => Message;

    public Truck(string message = "60 km/ hour") => Message = message;


}

public class Boat : Vehicle
{
    public string Message { get; set; }

    public override string Drive() => Message;

    public Boat(string message = "30 km/ hour") => Message = message;
}