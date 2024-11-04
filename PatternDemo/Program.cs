using PatternDemo.CompositePattern.Demo;
using PatternDemo.InterpreterPattern.Demo;
using PatternDemo.MediatorPattern.Demo;
using PatternDemo.StrategyPattern.Demo;
using PatternDemo.TemplateMethodPattern.Demo.SOLID;
using PatternDemo.TemplateMethodPattern.Demo.TemplateMethod;
using PatternDemo.VisitorPattern.Demo;
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
            InnescoMediator innescomedia = new InnescoMediator();
            innescomedia.Partenza();

            InnescoStrategy InnescoStr = new InnescoStrategy();
            InnescoStr.Innesco();
               //Innesco innesco = new Innesco();
               //innesco.VisitorStart();

            InnescoTemplate template = new InnescoTemplate();
            template.StartInnesco();

            InnescoSolido innescoSolido = new InnescoSolido();
            innescoSolido.StartInnesco();

            var root = new CompositeNode("Root");

            var node1 = new CompositeNode("node1", root);
            var leaf11 = new NodoFiglio("leaf11", node1);
            var leaf12 = new NodoFiglio("leaf12", node1);
            node1.Add(leaf11);
            node1.Add(leaf12);

            var node2 = new CompositeNode("node2", root);
            var leaf1 = new NodoFiglio("leaf1", root);

            root.Add(leaf1);
            root.Add(node1);
            root.Add(node2);

            Console.WriteLine("Root ======");
            root.PrintParent();
            root.PrintChildren();

            Console.WriteLine("leaf1 ======");
            leaf1.PrintParent();

            Console.WriteLine("node1 ======");
            node1.PrintParent();
            node1.PrintChildren();

            Console.WriteLine("leaf11 ======");
            leaf11.PrintParent();
            

            Console.WriteLine("Provide a word with expression");
            var word = "Prova-Test";

            var value = word.Substring(0, word.IndexOf("-"));
            var expressions = word.Substring(word.IndexOf("-"));

            var interpreter = new Interpreter();
            interpreter.Interpret(new Context(expressions, value));
        }
    }
}


