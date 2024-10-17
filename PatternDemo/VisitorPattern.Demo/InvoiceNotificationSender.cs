using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.VisitorPattern.Demo
{
    internal class InvoiceNotificationSender : INotificationSender
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Send(string message)
        {
            Console.WriteLine($"Notification sent: {message}");
        }
    }
}
