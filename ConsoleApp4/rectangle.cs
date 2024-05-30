namespace ConsoleApp4;

public class Rectangle : shape
{
    public int en {  get; set; }
    public int uzunluq { get; set; }
    public Rectangle(int En,int Uzunluq)
    {
        en= En;
        uzunluq= Uzunluq;
    }
    public override void area()
    {
        Console.WriteLine(en * uzunluq);
    }

    public override void perimetr()
    {
        Console.WriteLine((uzunluq+en)*2);
    }

    public override string ToString()
    {
        return $"Eni:{en}\nUzunlugu:{uzunluq}";
    }
}
