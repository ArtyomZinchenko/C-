// Разработать абстрактный класс «Геометрическая Фигура» с методами «Площадь Фигуры» и «Периметр Фигуры».
// Разработать классы-наследники: Треугольник, Квадрат, Прямоугольник, Круг. Реализовать конструкторы, которые однозначно определяют 
// объекты данных классов.

// Также реализовать класс «Составная Фигура», который может состоять из любого количества «Геометрических Фигур». 
// Для данного класса определить метод нахождения площади фигуры.

using System;

Triangle triangle = new Triangle(baseTR: 13, side1: 14, side2: 15, height: 12);
// Shape shape = new Triangle(); //all default parameters
Square square = new(side: 23);
Circle circle = new(radius: 12);
Rombus rombus = new(diagonal1: 5, diagonal2: 4, side: 2);
// System.Console.WriteLine(triangle.Area());
// System.Console.WriteLine(square.Area());
// System.Console.WriteLine(circle.Perimeter());

CompositeShape compositshape = new(triangle, square, circle);

System.Console.WriteLine(compositshape.Area());


public abstract class Shape
{
    public abstract double Area();
    public abstract double Perimeter();
}

public class Square : Shape
{

    public double Side { get; set; }

    public override double Area() => Side * Side;
    public override double Perimeter() => Side * 4;

    public Square(double side) => Side = side;
}

public class Triangle : Shape
{
    public double Base { get; set; } //основание
    public double Height { get; set; } //высота
    public double Side1 { get; set; } // одна сторона кроме основания
    public double Side2 { get; set; } // вторая сторона кроме основания
    public override double Area() => (Base * Height) * 0.5;
    public override double Perimeter() => Base + Side1 + Side2;

    // Constructors

    public Triangle(double baseTR = 0, double side1 = 0, double side2 = 0, double height = 0)
    {
        Base = baseTR;
        Side1 = side1;
        Side2 = side2;
        Height = height;
    }

}


public class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area() => (Radius * Radius) * Math.PI;

    public override double Perimeter() => 2 * Math.PI * Radius;

    public Circle(double radius = 0) => Radius = radius;

}


public class Rombus : Shape
{
    public double Diagonal1 { get; set; }
    public double Diagonal2 { get; set; }
    public double Side { get; set; }
    public override double Area() => (Diagonal1 * Diagonal2) / 2;
    public override double Perimeter() => Side * 4;
    public Rombus(double diagonal1 = 0, double diagonal2 = 0, double side = 0)
    {
        Diagonal1 = diagonal1;
        Diagonal2 = diagonal2;
        Side = side;
    }

}

public class CompositeShape : Shape
{
    private Shape[] shapes;

    public CompositeShape(params Shape[] shapes)
    {
        this.shapes = shapes;
    }

    public override double Area()
    {
        double totalArea = 0;

        foreach (Shape shape in shapes)
        {
            totalArea += shape.Area();
        }

        return totalArea;
    }

    public override double Perimeter()
    {
        double totalPerimeter = 0;

        foreach (Shape shape in shapes)
        {
            totalPerimeter += shape.Perimeter();
        }

        return totalPerimeter;
    }
}