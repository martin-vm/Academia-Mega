

public struct Punto
{
    public int x;
    public int y;

    public Punto(int x , int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Display()
    {
        Console.WriteLine(x);
        Console.WriteLine(y);
    }
}
