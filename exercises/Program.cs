using System;

class Program
{
    public static void Main(string[] args)
    {
        int x, y;
        Console.Write("X:");
        x = int.Parse(Console.ReadLine());
        Console.Write("Y:");
        y = int.Parse(Console.ReadLine());

        Console.WriteLine("X + Y = "+ Sum(x,y));
    }

    public static int Sum(int x, int y)
    {
        return x + y;
    }
}
