using DesingPatterns_SOLID.src.DesignPatterns.Behavioral.Memento;
using DesingPatterns_SOLID.src.OopPrinciples.Coupling;
using DesingPatterns_SOLID.src.SOLID._3._LSP;
using DesingPatterns_SOLID.src.SOLID.OCP;
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
            //var order = new Order(new SmsSender());

            //order.PlaceOrder();

            //Solid LSP
            //Shape rectangle = new Rectangle { Widht = 5, Height = 4 };
            //Rectangle rectangle = new Rectangle { Widht = 5, Height = 4 };

            //====== DESIGN PATTERNS========//

            //Memento
            //Used to restore an object to a previous state

            //var editor = new Editor();
            //var history = new History(editor);
            //history.Backup();
            //editor.Title = "Text";
            //history.Backup();
            //editor.Content = "Hello there, my name is Carolina";
            //history.Backup();
            //editor.Title = "The life of a dev: my mementos";


        }
    }
}
