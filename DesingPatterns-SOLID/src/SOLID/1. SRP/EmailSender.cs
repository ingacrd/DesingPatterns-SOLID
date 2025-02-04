using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_SOLID.src.SOLID.SRP
{
    internal class EmailSender
    {
        public void SendEmail(string email, string message)
        {
            Console.WriteLine(message + " to " + email);
        }
    }
}
