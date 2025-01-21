﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_SOLID.src.OopPrinciples.Coupling
{
    internal class SmsSender : INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("Sms message: " + message);
        }
    }
}
