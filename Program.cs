Console.Title = "The Colour";


Colour random = new Colour(25, 25, 233);

Colour fixedColour = Colour.White;

Console.WriteLine($"{fixedColour.R}, {fixedColour.G}, {fixedColour.B}");

Console.WriteLine($"{random.R}, {random.G}, {random.B}");




//Class will consist of three parts
public class Colour
{
    //variables for colours
    public byte R { get; }
    public byte G { get; }
    public byte B { get; }

    //constructor to create new colour
    public Colour(byte r, byte g, byte b)
    {
    
        R = r;
        G = g;
        B = b;

    }

    public Colour() { }
    //static variables for common colours
    public static Colour White { get; } = new Colour(255, 255, 255);
    public static Colour Black { get; } = new Colour(0, 0, 0);
    public static Colour Red { get; } = new Colour(255, 0, 0);
    public static Colour Orange { get; } = new Colour(255, 165, 0);
    public static Colour Yellow { get; } = new Colour(255, 255, 0);
    public static Colour Green { get; } = new Colour(0, 128, 0);
    public static Colour Blue { get; } = new Colour(0, 0, 255);
    public static Colour Purple { get; } = new Colour(128, 0, 128);
}

