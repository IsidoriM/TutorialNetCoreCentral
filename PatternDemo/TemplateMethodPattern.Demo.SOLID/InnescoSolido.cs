using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.TemplateMethodPattern.Demo.SOLID
{
    public  class InnescoSolido
    {
        public void StartInnesco()
        {
            var itemValidator = new ItemValidator();
            var paymentExecutor = new PaymentExecutor();

            var emailReciptSender = new EmailReceiptSender();
            var textReceiptSender = new TextReceiptSender();

            var cart = new Cart(itemValidator, paymentExecutor, emailReciptSender);
            cart.Checkout();

            cart = new Cart(itemValidator, paymentExecutor, textReceiptSender);
            cart.Checkout();
        }
    }
}
