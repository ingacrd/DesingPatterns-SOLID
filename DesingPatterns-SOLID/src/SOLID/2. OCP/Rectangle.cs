using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_SOLID.src.SOLID.OCP
{
    internal class Rectangle : Shape
    {
        public int Lenght { get;  set; }
        public int Width { get;  set; }

        public override double CalculateArea()
        {
            return Lenght * Width;
        }
    }
}
