namespace ColorBallGame;

using System;

public class Ball
{
    private int _size;
    private Color _color;
    private int _throwCount;

    // Constructor
    public Ball(int size, Color color)
    {
        if (size < 0)
            throw new ArgumentException("Size cannot be negative.");
        
        _size = size;
        _color = color;
        _throwCount = 0;
    }

    // Pop the ball (set size to 0)
    public void Pop()
    {
        _size = 0;
        Console.WriteLine("The ball has been popped!");
    }

    // Throw the ball (only if not popped)
    public void Throw()
    {
        if (_size > 0)
        {
            _throwCount++;
            Console.WriteLine($"The ball was thrown! Throw count: {_throwCount}");
        }
        else
        {
            Console.WriteLine("Cannot throw a popped ball.");
        }
    }

    // Get throw count
    public int GetThrowCount() => _throwCount;

    // Display ball info
    public override string ToString()
    {
        return $"Ball(Size:{_size}, Color:{_color}, Throws:{_throwCount})";
    }
}
