// Создайте абстрактный класс Animal с абстрактным методом MakeSound(), который будет представлять разные звуки, издаваемые разными животными. 
// Затем создайте несколько производных классов, представляющих различные виды животных (например, Dog, Cat, Horse), 
// и переопределите метод MakeSound() для каждого класса так, чтобы он возвращал соответствующий звук.

Dog dog = new();
Cat cat = new();
Horse horse = new();
// dog.Sound = "Miau";
System.Console.WriteLine(dog.MakeSound());
System.Console.WriteLine(cat.MakeSound());
System.Console.WriteLine(horse.MakeSound());

public abstract class Animal
{
    public abstract string MakeSound();

}

public class Dog : Animal
{
    public string Sound { get; } // I removed set; here to not let people change the sounds

    public override string MakeSound() => Sound;

    public Dog(string sound = "Gav-gav") => Sound = sound;
}

public class Cat : Animal
{
    public string Sound { get; } // I removed set; here to not let people change the sounds

    public override string MakeSound() => Sound;

    public Cat(string sound = "Miau") => Sound = sound;
}

public class Horse : Animal
{
    public string Sound { get; } // I removed set; here to not let people change the sounds

    public override string MakeSound() => Sound;

    public Horse(string sound = "Igogo") => Sound = sound;
}






