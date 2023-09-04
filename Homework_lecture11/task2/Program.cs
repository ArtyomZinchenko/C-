// Реализуйте класс “Студент”. Необходимо хранить в переменных-членах класса: ФИО, дату рождения, 
// контактный телефон, город, страну, название учебного заведения, город и страну (где находится учебное заведение), 
// номер группы. Реализуйте функции-члены класса для ввода данных, вывода данных, реализуйте аксессоры для 
// доступа к отдельным переменным-членам. К уже реализованному классу Student добавьте необходимые конструкторы.

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Create an array to hold Student objects
//         Student[] myStudentArray = new Student[2];

//         // Create and add some students to the array
//         Student student1 = new Student 
//         { 
//             FullName = "Oleksandr Kravchenko", 
//             BirthDate = "1990-01-01", 
//             ContactPhone = "123-456-7890", 
//             City = "Kiev", 
//             Country = "Ukraine", 
//             SchoolName = "XYZ University", 
//             SchoolCity = "New York", 
//             SchoolCountry = "USA", 
//             GroupNumber = "CS101" 
//         };

//         Student student2 = new Student
//         { 
//             FullName = "Artyom Zinchenko", 
//             BirthDate = "1988-09-24", 
//             ContactPhone = "098-765-4321", 
//             City = "Bukhara", 
//             Country = "Uzbekistan", 
//             SchoolName = "ABC University", 
//             SchoolCity = "Bukhara", 
//             SchoolCountry = "Uzbekistan", 
//             GroupNumber = "CS102" 
//         };

//         myStudentArray[0] = student1;
//         myStudentArray[1] = student2;

//         // Function to find students from a given city
//         Console.WriteLine("Students from Bukhara:");
//         foreach (Student student in myStudentArray)
//         {
//             if (student.City == "Bukhara")
//             {
//                 Console.WriteLine(student.FullName);
//             }
//         }
//     }
// }


class Program
{
    static void Main(string[] args)
    {
        // Create a new student object
        Student student1 = new Student();

        // Input student data
        Console.WriteLine("Enter data for student 1:");
        student1.InputData();

        // Output student data
        Console.WriteLine("\nData for student 1:");
        student1.OutputData();
    }
}