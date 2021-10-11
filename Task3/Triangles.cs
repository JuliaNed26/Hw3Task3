using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public abstract class Triangle
    {
        readonly public double[] Sides;
        public Triangle(double side1, double side2, double side3)
        {
            if (side1 > 0 && side2 > 0 && side3 > 0 &&
                side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                Sides = new double[] { side1, side2, side3 };
            }
            else
            {
                throw new ArgumentException("Sum of two sides should be bigger than another side");
            }
        }

        public virtual double GetSquare()
        {
            double p = this.GetPerimeter() / 2;
            return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
        }

        public virtual double GetPerimeter()
        {
            return Sides[0] + Sides[1] + Sides[2];
        }
    }

    public class RightTriangle:Triangle
    {
        //sides[0] - leg1, sides[1] - leg2, sides[2] - hypotenuse
        public RightTriangle(double leg1,double leg2,double hypotenuse):base(leg1, leg2, hypotenuse)
        {
            if(leg1 * leg1 + leg2 * leg2 != hypotenuse * hypotenuse)
            {
                throw new ArgumentException("Hypotenuse^2 = leg1^2 + leg2^2!");
            }
        }
        public override double GetSquare()
        {
            return 0.5 * Sides[0] * Sides[1];
        }
    }
    public class IsoscelesTriangle : Triangle
    {
        //sides[0] - rib, sides[1] - rib, sides[2] - bottom
        public IsoscelesTriangle(double rib, double bottom) : base(rib,rib,bottom) { }
        public override double GetSquare()
        {
            return (Sides[2] * Math.Sqrt(4 * Sides[0] * Sides[0] - Sides[2] * Sides[2])) / 4;
        }

        public override double GetPerimeter()
        {
            return Sides[0] * 2 + Sides[2];
        }
    }

}
