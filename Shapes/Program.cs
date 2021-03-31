using System;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes c1 = new Circle(1, "red"); //  Shape parent class
            ((Circle)c1).GetCircumference();  //    Casting as child 
            (c1 as Circle).SetRadius(2);      // C# built in fuction
            Hexagon h1 = new Hexagon(2, "blue");
            Console.WriteLine(h1.GetArea());
        }
    }
}
