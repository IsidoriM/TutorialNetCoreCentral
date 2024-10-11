
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.CompositePattern.Demo
{
    internal  class NodoFiglio : Node
    {
        private readonly string name;
        private readonly Node parentNode;

        public override string Name => name;

        public NodoFiglio(string name, Node parentNode)
        {
            this.name = name;
            this.parentNode = parentNode;
        }

        public override void StampaPadre(Node node)
        {
            Console.WriteLine($"Parent: {parentNode.Name}");
        }
    }
}
