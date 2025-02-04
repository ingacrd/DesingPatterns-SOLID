using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_SOLID.src.SOLID._3._LSP
{
    internal class Rectangle : Shape
    {

        public virtual double Widht { get;  set; }
        public virtual double Height { get;  set; }
        public override double Area => Widht * Height;
    }
}
