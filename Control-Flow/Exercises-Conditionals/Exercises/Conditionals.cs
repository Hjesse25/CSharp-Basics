namespace Exercises;

public class Conditionals
{
    // Exercise 1: Ask user to enter a number between 1 and 10
    public void Exercise1()
    {
        Console.Write("Enter a number between 1 and 10: ");
        string input = Console.ReadLine() ?? "";
        int number = Convert.ToInt32(input);

        if (number >= 1 && number <= 10)
            Console.WriteLine("Valid");
        else
            Console.WriteLine("Invalid");
    }

    // Exercise 2: Takes two numbers and determines the maximum
    public void Exercise2()
    {
        Console.Write("Enter a number: ");
        string num1Input = Console.ReadLine() ?? "";
        int num1 = Convert.ToInt32(num1Input);

        Console.Write("Enter another number: ");
        string num2Input = Console.ReadLine() ?? "";
        int num2 = Convert.ToInt32(num2Input);

        if (num1 > num2)
            Console.WriteLine($"{num1} is greater than {num2}");
        else if (num2 > num1)
            Console.WriteLine($"{num2} is greater than {num1}");
        else
            Console.WriteLine($"Both numbers are equal.");
    }

    /*
        Exercise 3: Takes the width and height of an image and
        displays if the image is landscape or portrait.
    */
    public void Exercise3()
    {
        Console.Write("Enter the width of the image: ");
        string widthInput = Console.ReadLine() ?? "";
        int width = Convert.ToInt32(widthInput);

        Console.Write("Enter the height of the image: ");
        string heightInput = Console.ReadLine() ?? "";
        int height = Convert.ToInt32(heightInput);

        var imageResolution = "";

        if (width > height)
            imageResolution = "Landscape";
        else if (height > width)
            imageResolution = "Portrait";

        Console.WriteLine($"Image resolution: {imageResolution}");
    }

    /*
        Exercise 4: Checks the car speed and speed limit. If the car speed 
        goes above the limit, it would add demerit points.
    */
    public void Exercise4()
    {
        Console.Write("What is the speed of the car?: ");
        string carSpeedInput = Console.ReadLine() ?? "";
        int carSpeed = Convert.ToInt32(carSpeedInput);

        Console.Write("What is the speed limit: ");
        string speedLimitInput = Console.ReadLine() ?? "";
        int speedLimt = Convert.ToInt32(speedLimitInput);

        if (carSpeed > speedLimt)
        {
            const int mphDemeritPoint = 5;
            var demerit = (carSpeed - speedLimt) / mphDemeritPoint;

            if (demerit > 12)
                Console.WriteLine("License suspended.");
            else
                Console.WriteLine($"Demerit Points: {demerit}");
        }
        else
        {
            Console.WriteLine("Ok");
        }
    }
}
