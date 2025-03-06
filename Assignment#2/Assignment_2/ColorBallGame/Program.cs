// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;

namespace ColorBallGame;
class Program
{
    static void Main()
    {
        // Create colors
        Color redColor = new Color(255, 0, 0);
        Color blueColor = new Color(0, 0, 255);
        Color greenColor = new Color(0, 255, 0, 128);

        // Create balls with different colors and sizes
        Ball redBall = new Ball(10, redColor);
        Ball blueBall = new Ball(15, blueColor);
        Ball greenBall = new Ball(20, greenColor);

        // Throw the balls
        redBall.Throw();
        redBall.Throw();
        blueBall.Throw();

        // Pop the red ball and try throwing it again
        redBall.Pop();
        redBall.Throw(); // Should not increase throw count

        // Display final throw counts
        Console.WriteLine($"Red Ball Throw Count: {redBall.GetThrowCount()}");
        Console.WriteLine($"Blue Ball Throw Count: {blueBall.GetThrowCount()}");
        Console.WriteLine($"Green Ball Throw Count: {greenBall.GetThrowCount()}");

        // Display ball details
        Console.WriteLine(redBall);
        Console.WriteLine(blueBall);
        Console.WriteLine(greenBall);

        // Display grayscale values of colors
        Console.WriteLine($"Red Color Grayscale: {redColor.GetGrayscale()}");
        Console.WriteLine($"Blue Color Grayscale: {blueColor.GetGrayscale()}");
        Console.WriteLine($"Green Color Grayscale: {greenColor.GetGrayscale()}");
    }
}
