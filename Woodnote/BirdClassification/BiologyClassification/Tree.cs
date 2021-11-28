using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("BirdClassification.Tests")]

namespace BirdClassification.BiologyClassification
{
    internal class Tree
    {
        public System.Enum Obj { get; }
        public Tree Parent { get; set; } = null;
        public List<Tree> Nodes { get; } = new List<Tree>();


        public Tree(System.Enum obj)
        {
            Obj = obj;
        }


        public void AddChild(System.Enum obj)
        {
            var childTree = new Tree(obj);
            childTree.Parent = this;

            Nodes.Add(childTree);
        }

        public List<object> GetAllParentNodes(System.Enum obj)
        {
            TryGetParentNodes(this.Nodes, obj, out List<object> parentNodes);
            return parentNodes;
        }

        private bool TryGetParentNodes(List<Tree> nodes, Enum obj, out List<object> parentNodes)
        {
            foreach (Tree node in nodes)
            {
                if (node.Obj.GetType() == obj.GetType()
                    && Convert.ToInt32(node.Obj) == Convert.ToInt32(obj))
                {
                    parentNodes = GetAllParentNodes(node);
                    return true;
                }
            }

            foreach (Tree node in nodes)
            {
                if (node.Nodes.Count > 0)
                {
                    if (TryGetParentNodes(node.Nodes, obj, out parentNodes))
                    {
                        return true;
                    }
                }
            }

            parentNodes = new List<object>();
            return false;
        }

        private List<object> GetAllParentNodes(Tree node)
        {
            Tree parent = node.Parent;
            List<object> output = new List<object>();

            while (parent != null)
            {
                output.Add(parent.Obj);
                parent = parent.Parent;
            }

            return output;
        }
    }
}
