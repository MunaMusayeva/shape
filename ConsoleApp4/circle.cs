namespace ConsoleApp4;

internal class circle:shape
{
    public int radius { get; set; }
    public circle(int Radius)
    {
        radius = Radius;
    }
    public override void area()
    {
        Console.WriteLine(3.14*(radius*radius));
    }

    public override void perimetr()
    {
        Console.WriteLine(2*3.14*radius);
    }

    public override string ToString()
    {
        return $"radius:{radius}";
    }
}
