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

        public List<System.Enum> GetAllParentNodes(System.Enum obj)
        {
            foreach (Tree node in this.Nodes)
            {
                if (node.Obj.GetType() == obj.GetType() 
                    & Convert.ToInt32(node.Obj) == Convert.ToInt32(obj))
                {
                    return GetAllParentNodeObjects(node);
                }
            }

            foreach (Tree node in this.Nodes)
            {
                if (node.Nodes.Count > 0)
                {
                    return node.GetAllParentNodes(obj);
                }
            }

            return new List<System.Enum>();
        }

        private List<System.Enum> GetAllParentNodeObjects(Tree node)
        {
            List<System.Enum> output = new List<System.Enum>();
            Tree parent = node.Parent;

            while (parent != null)
            {
                output.Add(parent.Obj);
                parent = parent.Parent;
            }

            return output;
        }
    }
}
