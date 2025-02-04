using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_SOLID.src.SOLID._5._DIP
{
    public class Engine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Engine Started");
        }
    }
}
