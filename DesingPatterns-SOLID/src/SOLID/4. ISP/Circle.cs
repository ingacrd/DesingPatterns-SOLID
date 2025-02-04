using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_SOLID.src.SOLID._4._ISP { 
public class Circle : IShape2D
        //public class Circle : IShape
    {
    public double Radius { get; set; }

    public double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    public double Volume()
    {
        throw new InvalidOperationException("Volume not applicable for 2D shapes");
    }
}
}
