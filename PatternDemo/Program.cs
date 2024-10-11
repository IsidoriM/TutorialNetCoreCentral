using PatternDemo.CompositePattern.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new CompositeNode("Root");

            var node1 = new CompositeNode("node1", root);
            var leaf11 = new NodoFiglio("leaf11", node1);
            var leaf12 = new NodoFiglio("leaf12", node1);
            node1.Add(leaf11);
            node1.Add(leaf12);

            var node2 = new CompositeNode("node2", root);
            var leaf21 = new NodoFiglio("leaf21", root);

            root.Add(leaf21);
            root.Add(node1);
            root.Add(node2);

            Console.WriteLine("Root ======");
            root.StampaPadre(node1);
            root.StampaFiglio(node1);

            Console.WriteLine("leaf1 ======");
            leaf21.StampaPadre(node1);

            Console.WriteLine("node1 ======");
            node1.StampaPadre(node1);
            node1.StampaFiglio(node1);

            
        }
    }

}
