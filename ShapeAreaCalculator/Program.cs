namespace ShapeAreaCalculator;

class Program
{
    static void Main(string[] args)
    {
        
    }
    
    public static double AreaOfCircle(double radius)
    {
        return Math.PI * (radius * radius);
    }
    
    public static double AreaOfTriangle(double baseLength, double height)
    {
        return (baseLength * height)/2;
    }
    
    public static double AreaOfRectangle(double length, double width)
    {
        return length * width;
    }
}