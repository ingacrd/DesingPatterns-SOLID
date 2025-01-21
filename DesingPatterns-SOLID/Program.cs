using DesingPatterns_SOLID.src.OopPrinciples.Coupling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var order = new Order(new EmailSender());
            var order = new Order(new SmsSender());

            order.PlaceOrder();
        }
    }
}
