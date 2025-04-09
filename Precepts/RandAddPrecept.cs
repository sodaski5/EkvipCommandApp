using System;

public class RandAddPrecept : IPrecept
{
    private int _delta;
    private static Random _arbitrary = new Random();

    public RandAddPrecept()
    {
        _delta = _arbitrary.Next(-111, 111); // Random number from -111 to +100
    }

    public int Run(int current) => current + _delta;
    public int Setback(int current) => current - _delta;
}