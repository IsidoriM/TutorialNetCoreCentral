using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.StrategyPattern.Demo
{
    internal interface ISortStrategy
    {
        int[] Sort(int[] inputArray);
    }
}
