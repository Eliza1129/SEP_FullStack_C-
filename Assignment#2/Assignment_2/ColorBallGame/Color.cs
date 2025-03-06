namespace ColorBallGame;

using System;

public class Color
{
    private int _red;
    private int _green;
    private int _blue;
    private int _alpha;

    // Constructor with Red, Green, Blue, and Alpha
    public Color(int red, int green, int blue, int alpha)
    {
        _red = ValidateColorValue(red);
        _green = ValidateColorValue(green);
        _blue = ValidateColorValue(blue);
        _alpha = ValidateColorValue(alpha);
    }

    // Constructor with Red, Green, Blue (Alpha defaults to 255)
    public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

    // Color component validation
    private int ValidateColorValue(int value)
    {
        if (value < 0 || value > 255)
            throw new ArgumentOutOfRangeException("Color values must be between 0 and 255.");
        return value;
    }

    // Getters and Setters
    public int Red { get => _red; set => _red = ValidateColorValue(value); }
    public int Green { get => _green; set => _green = ValidateColorValue(value); }
    public int Blue { get => _blue; set => _blue = ValidateColorValue(value); }
    public int Alpha { get => _alpha; set => _alpha = ValidateColorValue(value); }

    // Method to get grayscale value
    public int GetGrayscale() => (_red + _green + _blue) / 3;

    // Display color
    public override string ToString()
    {
        return $"Color(R:{_red}, G:{_green}, B:{_blue}, A:{_alpha})";
    }
}
