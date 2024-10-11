using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternDemo.CompositePattern.Demo
{
    internal  abstract class Node
    {
        public abstract string Name { get; }
        public virtual void Add(Node node) => throw new NotImplementedException();

        public virtual void Remove(Node node) => throw new NotImplementedException();

        public virtual void StampaFiglio(Node node) => throw new NotImplementedException();

        public virtual void StampaPadre(Node node) => throw new NotImplementedException();

    }
}
