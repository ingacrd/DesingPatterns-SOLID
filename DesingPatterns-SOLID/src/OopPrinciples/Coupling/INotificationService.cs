﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns_SOLID.src.OopPrinciples.Coupling
{
    internal interface INotificationService
    {
        void SendNotification(string message);
    }
}
