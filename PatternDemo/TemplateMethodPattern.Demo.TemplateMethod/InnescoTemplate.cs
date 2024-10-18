using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.TemplateMethodPattern.Demo.TemplateMethod
{
    internal class InnescoTemplate
    {
        public void StartInnesco()
        {
            var cart = new EmailCart();
            cart.Checkout();

            var cart1 = new TextCart();
            cart1.Checkout();
        }
        
    }
}
