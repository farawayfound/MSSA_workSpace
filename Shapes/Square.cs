using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Square : Shapes
    {
        //   F i e l d s

        private double side;

        //   C o n s t r u c t o r s
        public Square() : this(1.0, "red") //calls next constructor and assigns input
        {
        }

        public Square(double side, string color) : base(color) //constructors must have the same name as the class
        {
            SetSide(side);
        }

        //   M e t h o d s

        public override double GetArea()
        {
            return side * side;
        }
        public override double GetPerimeter()
        {
            return 4 * side;
        }
        public double GetSide()
        {
            return side;
        }
        public void SetSide(double side)
        {
            if (side < 0)
            {
                side = -side;
            }
            if (side == 0)
            {
                side = 1;
            }
            this.side = side;
        }
    }
}
