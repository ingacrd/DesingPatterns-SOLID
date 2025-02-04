using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_SOLID.src.SOLID._3._LSP
{
    //    internal class Square: Rectangle
    internal class Square : Shape
    {
        //public override double Widht
        //{
        //    get => base.Widht;
        //    set => base.Widht = base.Height = value;
        //}

        //public override double Height
        //{
        //    get => base.Height;
        //    set => base.Height = base.Widht = value;
        //}

        public double SideLenght { get; set; }
        public override double Area => SideLenght * SideLenght;
    }
}
