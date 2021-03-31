using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Circle : Shapes
    {
        //   F i e l d s

        private double radius = 1;
        
        //   C o n s t r u c t o r s
        public Circle() : this(1.0, "red") //calls next constructor and assigns input
        {
        }

        public Circle(double radius, string color) : base(color) //constructors must have the same name as the class
        {
            SetRadius(radius);
        }

        //   M e t h o d s

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public double GetCircumference()
        {
            return GetPerimeter();
        }
        public override double GetPerimeter()
        {
            return Math.PI * 2.0 * radius;
        }

        public double GetRadius()
        {
            return radius;
        }
     
        public void SetRadius(double radius)
        {
            if (radius < 0)
            {
                radius = -radius;
            }
            if (radius == 0)
            {
                radius = 1;
            }
            this.radius = radius;
        }
    }
}

