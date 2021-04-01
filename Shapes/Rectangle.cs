using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shapes
    {
        //   F i e l d s

        private double length;
        private double width;

        //   C o n s t r u c t o r s
        public Rectangle() : this(1.0, 1.0) //calls next constructor and assigns input
        {
        }

        public Rectangle(double length, double width, string color="red") : base(color) //constructors must have the same name as the class
        {
            SetLength(length);
            SetWidth(width);
        }

        //   M e t h o d s
    
        public override double GetArea()
        {
            return length * width;
        }
        public override double GetPerimeter()
        {
            return 2 * (length + width);
        }
        public double GetLength()
        {
            return length;
        }
        public double GetWidth()
        {
            return width;
        }
        public void SetLength(double length)
        {
            if (length < 0)
            {
                length = -length;
            }
            if (length == 0)
            {
                length = 1;
            }
            this.length = length;
        }
        public void SetWidth(double width)
        {
            if (width < 0)
            {
                width = -width;
            }
            if (width == 0)
            {
                width = 1;
            }
            this.width = width;
        }
    }
}
