using System.Drawing;
using System.Runtime.CompilerServices;

public interface IShape
{
    public void CalculateArea();
}
public interface IColor
{
    public string Color { get; set; }
}
public class Circle : IShape, IColor
{
    private double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;        
    }
    public Circle(double radius,string color)
    {
        this.Radius = radius;
        string Color=color;  
    }
    public void CalculateArea()
    {
        double Area;
        Area= 3.14 *Radius*Radius;
        Console.WriteLine(Area);
    }
    public string Color { get; set; }
}
public class Rectangle : IShape, IColor
{
    private double Width { get; set; }
    private double Height { get; set; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
        
    }
    public Rectangle(double width, double height, string color)
    {
        Width = width;
        Height = height;
        string Color = color;
    }
    public void CalculateArea()
    {
        double Area;
        Area= Width *Height;
        Console.WriteLine(Area);
    }
    public string Color { get; set; }   
}


