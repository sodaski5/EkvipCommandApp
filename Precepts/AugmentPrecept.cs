public class AugmentPrecept : IPrecept
{
    public int Run(int current) => current + 1;
    public int Setback(int current) => current - 1;
}
