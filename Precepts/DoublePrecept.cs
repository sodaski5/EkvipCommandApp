public class DoublePrecept : IPrecept
{
    public int Run(int current) => current * 2;
    public int Setback(int current) => current / 2;
}
