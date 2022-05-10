using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        //Calculate circle's circumference and area
        //prompt user to enter a radius; the user may enter a decimal. error if invalid and ask again
        //when valid data entered, calculates the area and circumference of circle and rounds to nearest 2 decimal places
        //Print out both then ask if they want to do another?
        //Goodbye message includes the number of circles the user built when the user chooses not to continue

        //Build Specs 1..Circle class to store data.  Should have these constructors and methods:a. public Circle(double radius)
        //b. public double CalculateCircumference() c. public string CalculateFormattedCircumference()
        //d. public double CalculateArea(). e. public string CalculateFormattedArea() f. private string FormatNumber(double x)
        //g. define a member called radius. (private) h. define property to get access to the class member: radius
        //2. for pi, use the PI constant of the System.Math class
        //3. In Main, get the user input, create a circle object, and display the circumference and area.
        bool valid = true;
        bool create = true;
        double newRadius = 0;
        double counter = 0;
        
        do
        {

            do
            {

                Console.WriteLine("Enter the radius");
                newRadius = double.Parse(Console.ReadLine());

                if (newRadius <= 0)
                {
                    valid = true;
                    Console.WriteLine("Sorry, that is not valid.");
                }
                else
                {
                    valid = false;
                    counter++;
                    Circle newCircle = new Circle(newRadius);
                    Console.WriteLine(newCircle.CalculateFormattedCircumference());
                    Console.WriteLine(newCircle.CalculateFormattedArea());
                    //Console.WriteLine(newCircle.FormatNumber(counter)); If you changed to public below you could print the # of circles done so far
                }
            } while (valid);
            Console.WriteLine("Would you like to do another?");
            string yes = Console.ReadLine();
            if (yes == "y")
            {
                create = true;
            }
            else
            {
                create = false;
                Console.WriteLine($"Goodbye, you did {counter} total circles.");
            }
        } while (create);
        
    }

}
public class Circle
{
    public double radius { get; private set; }

    public Circle(double newRadius)
    {
        radius = newRadius;
    }
    public double CalculateCircumference()
    {
        double circum = Math.Round( 2 * Math.PI * radius, 2);
        return circum;
    }
    public string CalculateFormattedCircumference()
    {
        return $"The circumference of your circle is {CalculateCircumference()}";
    }
    public double CalculateArea()
    {
        double area = Math.Round(Math.PI * radius * radius, 2);
        return area;
    }
    public string CalculateFormattedArea()
    {
        return $"The area of the circle is {CalculateArea()}";
        
    }
    private string FormatNumber(double x)
    {
        return $"You did {x} circles so far!";
    }
        
}
