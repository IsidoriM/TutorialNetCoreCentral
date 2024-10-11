using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.CompositePattern.Demo
{
    internal  class CompositeNode : Node 
    {
        private List<Node> children = new List<Node>();
        private readonly string name;
        private readonly Node parentNode;

        public override string Name => name;

        public CompositeNode(string nome, Node parentNode = null)
        {
            this.name = nome;
            this.parentNode = parentNode;
        }
        public override void Add(Node node)
        {
            children.Add(node);
        }

        public override void Remove(Node node)
        {
            children.Remove(node);
        }

        public override void StampaFiglio(Node node)
        {
            if (parentNode != null)
                Console.WriteLine($"Parent: {parentNode.Name}");
            else
                Console.WriteLine("Root node");
        }

        public override void StampaPadre(Node node)
        {
            Console.WriteLine
            ($"Children: {string.Join(",", children.Select(c => c.Name))}");
        }






    }
}
