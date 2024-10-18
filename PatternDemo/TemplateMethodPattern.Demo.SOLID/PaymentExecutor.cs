using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.TemplateMethodPattern.Demo.SOLID
{
    public class PaymentExecutor : IPaymentExecutor
    {
        public void ExecutePayment()
        {
            Console.WriteLine("Payment executed");
        }
    }

    public interface IReceiptSender
    {
        void SendReceipt();
    }

    public class EmailReceiptSender : IReceiptSender
    {
        public void SendReceipt()
        {
            Console.WriteLine("Email Sent");
        }
    }

    public class TextReceiptSender : IReceiptSender
    {
        public void SendReceipt()
        {
            Console.WriteLine("Text Sent");
        }
    }
}
