using System;

namespace Shapes
{
    public class Hexagon : Shapes // Is-A
    {

        // fields

        private double side = 1;

        // constructors

        public Hexagon(double side, string color) : base(color)
        {
            SetSide(side);
        }

        // methods

        public override double GetArea()
        {
            return 3.0 * Math.Sqrt(3.0) * side * side / 2.0;
        }

        public override double GetPerimeter()
        {
            return 6 * side;
        }

        public void SetSide(double side)
        {
            this.side = side;
        }
    }
}
