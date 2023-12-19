Rectangle rec = new Rectangle();
System.Console.WriteLine("width = ");
rec.Width = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("height = ");
rec.Height = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Area = " + rec.GetArea());


class Rectangle 
{
    public double Width;
    public double Height;
    public double GetArea()
    {
        return Width * Height;
    }
}