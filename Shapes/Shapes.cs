using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public abstract class Shapes
    {
        // F i e l d s

        private string color;


        // C o n s t r u c t o r s

        protected Shapes()
        {

        }

        protected Shapes(string color)
        {
            SetColor(color);
        }

        // M e t h o d s
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            if(color !=null && color !="")
            this.color = color;
        }
    }
}
