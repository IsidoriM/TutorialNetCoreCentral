using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.TemplateMethodPattern.Demo.SOLID
{
    public class ItemValidator : IItemValidator
    {
        public void ValidateItem()
        {
            Console.WriteLine("Item validated");
        }
    }
}
