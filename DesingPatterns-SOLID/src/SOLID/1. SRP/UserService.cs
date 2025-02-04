using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_SOLID.src.SOLID.SRP
{
    internal class UserService
    {
        //All logic for Register, log in User, Upated...
        public void Register (User user)
        {
            //Register logic
            //Send email
            EmailSender emailSender = new EmailSender ();
            emailSender.SendEmail(user.Email, "Welcome to pour platforme");
        }
    }
}
