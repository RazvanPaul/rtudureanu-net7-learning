/*using System.ComponentModel;

public abstract class Shape
{
    public string Color { get; set; }
    public double Area = 0;
    public double Perimeter;
    public abstract double CalculateArea();
    public virtual double GetPerimeter()
    {
        return Perimeter;
    }

}
public class Rectangle : Shape
{
    private double Width { get; set; }
    private double Height { get; set; }

    public Rectangle(string Color,double Width, double Height)
    {
        this.Color = Color;
        this.Width = Width;
        this.Height = Height;
    }
    public override double CalculateArea()
    {
        Area = Width * Height;
        return Area;
    }
    public override double GetPerimeter()
    {
        Perimeter= 2*(Width + Height);
        return Perimeter;

    }
}
public class Circle : Shape 
{ 
    private double Radius { get; set; }

    public Circle(string Color, double Radius)
    {
        this.Color = Color;
        this.Radius = Radius;
    }
    public override double CalculateArea()
    {
        Area = 3.14 * Radius * Radius;
        return Area;
    }
    public override double GetPerimeter()
    {
        double Circumference;
        Circumference=2*3.14*Radius;
        return Circumference;
    }
}*/



