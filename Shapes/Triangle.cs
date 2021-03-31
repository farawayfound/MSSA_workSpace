using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Triangle : Shapes
    {
        //   F i e l d s

        private double sideA;
        private double sideB;
        private double sideC;

        //   C o n s t r u c t o r s
        public Triangle() : this(1.0, 1.0, 1.0) //calls next constructor and assigns input
        {
        }

        public Triangle(double sideA, double sideB, double sideC, string color="red") : base(color) //constructors must have the same name as the class
        {
            SetSideA(sideA);
            SetSideB(sideB);
            SetSideC(sideC);
            if (sideA + sideB <= sideC)
            {
                Console.WriteLine("impossible triangle");
            }
            else if (sideA + sideC <= sideB)
            {
                Console.WriteLine("impossible triangle");
            }
            else if (sideB + sideC <= sideA)
            {
                Console.WriteLine("impossible triangle");
            }
        }

        //   M e t h o d s

        public override double GetArea()
        {
            double p = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
        }
        public override double GetPerimeter()
        {
            return sideA + sideB + sideC;
        }
        public double GetSideA()
        {
            return sideA;
        }
        public double GetSideB()
        {
            return sideB;
        }
        public double GetSideC()
        {
            return sideC;
        }
        public void SetSideA(double sideA)
        {
            if (sideA < 0)
            {
                sideA = -sideA;
            }
            if (sideA == 0)
            {
                sideA = 1;
            }
            this.sideA = sideA;
        }
        public void SetSideB(double sideB)
        {
            if (sideB < 0)
            {       
                sideB = -sideB;
            }      
            if (sideB == 0)
            {       
                sideB = 1;
            }
            this.sideB = sideB;
        }
        public void SetSideC(double sideC)
        {
            if (sideC < 0)
            {
                sideC = -sideC;
            }
            if (sideC == 0)
            {
                sideC = 1;
            }
            this.sideC = sideC;
        }
    }
}
