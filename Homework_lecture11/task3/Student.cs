// Реализуйте класс “Студент”. Необходимо хранить в переменных-членах класса: ФИО, дату рождения, 
// контактный телефон, город, страну, название учебного заведения, город и страну (где находится учебное заведение), 
// номер группы. Реализуйте функции-члены класса для ввода данных, вывода данных, реализуйте аксессоры для 
// доступа к отдельным переменным-членам. К уже реализованному классу Student добавьте необходимые конструкторы.



// К уже реализованному классу Student добавьте необходимые конструкторы. - не понял тут что нужно сделать...

public class Student
{
    public string FullName { get; set; }
    public string BirthDate { get; set; }
    public string ContactPhone { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string SchoolName { get; set; }
    public string SchoolCity { get; set; }
    public string SchoolCountry { get; set; }
    public string GroupNumber { get; set; }

    public Student(string fullName, string birthdate, string contactPhone, string city, string country,
        string schoolName, string schoolCity, string schoolCountry, string groupNumber)
    {
        FullName = fullName;
        BirthDate = birthdate;
        ContactPhone = contactPhone;
        City = city;
        Country = country;
        SchoolName = schoolName;
        SchoolCity = schoolCity;
        SchoolCountry = schoolCountry;
        GroupNumber = groupNumber;
    }

    public Student()
    {
    }
}
