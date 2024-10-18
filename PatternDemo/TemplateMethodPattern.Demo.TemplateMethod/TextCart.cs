using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.TemplateMethodPattern.Demo.TemplateMethod
{
    internal class TextCart : Cart
    {
        protected override void SendReceipt()
        {
            Console.WriteLine("Text Sent");
        }
    }
}
