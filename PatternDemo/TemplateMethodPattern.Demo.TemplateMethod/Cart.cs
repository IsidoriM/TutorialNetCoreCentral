using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.TemplateMethodPattern.Demo.TemplateMethod
{
    internal abstract class Cart
    {
        public void Checkout()
        {
            ValidateItem();
            ExecutePayment();
            SendReceipt();
        }

        protected abstract void SendReceipt();

        private void ExecutePayment()
        {
            Console.WriteLine("Payment executed");
        }

        private void ValidateItem()
        {
            Console.WriteLine("Item validated");
        }
    }
}
