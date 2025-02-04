using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_SOLID.src.SOLID.OCP
{
    public abstract class Shape
    {
        //public ShapeType Type { get; set; }
        //public double Radius { get; set; }
        //public double Lenght { get; set; }
        //public double Width { get; set; }

        public abstract double CalculateArea();
        //{
            //switch (Type) {
            //    case ShapeType.Circle:
            //        return Math.PI * Math.Pow(Radius, 2);
            //    case ShapeType.Rectangle:
            //        return Lenght * Width;
            //    default:
            //        throw new InvalidOperationException("Unsupported shape tupe");
            //}
        //}
    }
}
