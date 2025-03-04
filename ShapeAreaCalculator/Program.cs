namespace ShapeAreaCalculator;

class Program
{
    static void Main(string[] args)
    {
        //declare variables to store user input
        double userInput = 0;
        double userInput2 = 0;
        
        //declare variables to store area value of each shape
        double circleArea = 0;
        double triangleArea = 0;
        double rectangleArea = 0;
        double squareArea = 0;
        
        //prompt user for input and validate to ensure input is a number
        Console.WriteLine("Please enter the radius of the circle:");
        while (!double.TryParse(Console.ReadLine(), out userInput))
        {
            Console.WriteLine("Invalid input. Radius must be a number.");
        }
        
        //call AreaOfCircle method and output result
        circleArea = AreaOfCircle(userInput);
        
        Console.WriteLine($"Area of the circle is {circleArea:N}\n");
        
        Console.WriteLine("Please enter the base length of the triangle:");
        while (!double.TryParse(Console.ReadLine(), out userInput))
        {
            Console.WriteLine("Invalid input. Base length must be a number.");
        }
        
        Console.WriteLine("Please enter the height of the triangle:");
        while (!double.TryParse(Console.ReadLine(), out userInput2))
        {
            Console.WriteLine("Invalid input. Height must be a number.");
        }
        
        //call AreaOfTriangle method and output result
        triangleArea = AreaOfTriangle(userInput, userInput2);
        
        Console.WriteLine($"Area of the triangle is {triangleArea:N}\n");
        
        Console.WriteLine("Please enter the length of the rectangle:");
        while (!double.TryParse(Console.ReadLine(), out userInput))
        {
            Console.WriteLine("Invalid input. Length must be a number.");
        }
        
        Console.WriteLine("Please enter the width of the rectangle:");
        while (!double.TryParse(Console.ReadLine(), out userInput2))
        {
            Console.WriteLine("Invalid input. Width must be a number.");
        }
        
        //call AreaOfRectangle method and output result
        rectangleArea = AreaOfRectangle(userInput, userInput2);
        
        Console.WriteLine($"Area of the rectangle is {rectangleArea:N}\n");
        
        Console.WriteLine("Please enter the side length of the square:");
        while (!double.TryParse(Console.ReadLine(), out userInput))
        {
            Console.WriteLine("Invalid input. Side length must be a number.");
        }
        
        //call AreaOfsquare method and output result
        squareArea = AreaOfSquare(userInput);
        
        Console.WriteLine($"Area of the rectangle is {squareArea:N}\n");
    }
    
    //method to calculate the area of a circle
    public static double AreaOfCircle(double radius)
    {
        return Math.PI * (radius * radius);
    }
    
    //method to calculate the area of a triangle
    public static double AreaOfTriangle(double baseLength, double height)
    {
        return (baseLength * height)/2;
    }
    
    //method to calculate the area of a rectangle
    public static double AreaOfRectangle(double length, double width)
    {
        return length * width;
    }
    
    //method to calculate the area of a square
    public static double AreaOfSquare(double side)
    {
        return side * 4;
    }
}