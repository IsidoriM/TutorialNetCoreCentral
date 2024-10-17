using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.VisitorPattern.Demo
{
    internal interface IVisitor
    {
        void Visit(INotificationSender notificationSender);
    }
}
