using System;

public abstract class Figure
{
    public double Width,Height,Radius;
    public const float Pi =3.14f;
    public abstract double GetArea();

}
public class Rectangle : Figure
{
    public Rectangle(double Width,double Height)
    {
        this.Width = Width;
        this.Height = Height;

    }
    public override double GetArea()
    {
        return Width*Height;
    }

}
public class Circle: Figure
{
    public Circle(double Radius)
    {
        this.Radius = Radius;

    }
    public override double GetArea()
    {
        return Pi*Radius*Radius;
    }

}
public class Cone: Figure
{
    public Cone(double Radius,double Height)
    {
        this.Radius = Radius;
        this.Height = Height;

    }
    public override double GetArea()
    {
        return Pi*Radius*(Radius+Math.Sqrt(Height*Height+Radius*Radius));
    }
}
class TestFigures
{
    static void Main11()
    {
        Rectangle r = new Rectangle(12.67,56.78);
        Circle c = new Circle(23);
        Cone cn = new Cone(23,23);
        Console.WriteLine("Area of Rectangle "+ r.GetArea());
        Console.WriteLine("Area of Circle "+ c.GetArea());
        Console.WriteLine("Area of Cone "+ cn.GetArea());
    }
}