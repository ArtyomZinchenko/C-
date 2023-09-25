// Реализуйте класс “Студент”. Необходимо хранить в переменных-членах класса: ФИО, дату рождения, 
// контактный телефон, город, страну, название учебного заведения, город и страну (где находится учебное заведение), 
// номер группы. Реализуйте функции-члены класса для ввода данных, вывода данных, реализуйте аксессоры для 
// доступа к отдельным переменным-членам. К уже реализованному классу Student добавьте необходимые конструкторы.



// К уже реализованному классу Student добавьте необходимые конструкторы. - не понял тут что нужно сделать...



// public class Student
// {
//     public string FullName = "";
//     public string BirthDate = "";  // You can also use DateTime for a more accurate representation
//     public string ContactPhone = "";
//     public string City = "";
//     public string Country = "";
//     public string SchoolName = "";
//     public string SchoolCity = "";
//     public string SchoolCountry = "";
//     public string GroupNumber = "";
// }


using System;

public class Student
{
    // Private fields
    private string fullName;
    private string birthDate;
    private string contactPhone;
    private string city;
    private string country;
    private string schoolName;
    private string schoolCity;
    private string schoolCountry;
    private string groupNumber;

    // Public properties (accessors)
    public string FullName { get => fullName; set => fullName = value; }
    public string BirthDate { get => birthDate; set => birthDate = value; }
    public string ContactPhone { get => contactPhone; set => contactPhone = value; }
    public string City { get => city; set => city = value; }
    public string Country { get => country; set => country = value; }
    public string SchoolName { get => schoolName; set => schoolName = value; }
    public string SchoolCity { get => schoolCity; set => schoolCity = value; }
    public string SchoolCountry { get => schoolCountry; set => schoolCountry = value; }
    public string GroupNumber { get => groupNumber; set => groupNumber = value; }

    // Method for inputting data
    public void InputData()
    {
        Console.Write("Enter Full Name: ");
        FullName = Console.ReadLine();

        Console.Write("Enter Birth Date: ");
        BirthDate = Console.ReadLine();

        Console.Write("Enter Contact Phone: ");
        ContactPhone = Console.ReadLine();

        Console.Write("Enter City: ");
        City = Console.ReadLine();

        Console.Write("Enter Country: ");
        Country = Console.ReadLine();

        Console.Write("Enter School Name: ");
        SchoolName = Console.ReadLine();

        Console.Write("Enter School City: ");
        SchoolCity = Console.ReadLine();

        Console.Write("Enter School Country: ");
        SchoolCountry = Console.ReadLine();

        Console.Write("Enter Group Number: ");
        GroupNumber = Console.ReadLine();
    }

    // Method for outputting data
    public void OutputData()
    {
        Console.WriteLine($"Full Name: {FullName}");
        Console.WriteLine($"Birth Date: {BirthDate}");
        Console.WriteLine($"Contact Phone: {ContactPhone}");
        Console.WriteLine($"City: {City}");
        Console.WriteLine($"Country: {Country}");
        Console.WriteLine($"School Name: {SchoolName}");
        Console.WriteLine($"School City: {SchoolCity}");
        Console.WriteLine($"School Country: {SchoolCountry}");
        Console.WriteLine($"Group Number: {GroupNumber}");
    }
}
