using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.VisitorPattern.Demo
{
    internal class TextVisitor : IVisitor
    {
        public void Visit(INotificationSender notificationSender)
        {
            Console.WriteLine("Setup text");
        }
    }
}
