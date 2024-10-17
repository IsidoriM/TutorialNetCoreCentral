using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.VisitorPattern.Demo
{
    internal interface INotificationSender
    {
        void Send(string message);
        void Accept(IVisitor visitor);
    }
}
