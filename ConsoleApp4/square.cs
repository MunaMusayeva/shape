namespace ConsoleApp4;

public class square:shape
{
    public int teref { get; set; }
    public square(int Teref)
    {
        teref = Teref;
    }

    public override void area()
    {
        Console.WriteLine(teref*teref);
    }

    public override void perimetr()
    {
        Console.WriteLine(teref * 4);
    }

    public override string ToString()
    {
        return $"teref:{teref}";
    }
}
