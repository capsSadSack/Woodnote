using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdClassification.AuxModels
{
    internal class Tree
    {
        private static long _id = 0;

        // Уникальное имя
        public string Name { get; }
        public string Text { get; }
        public List<Tree> Nodes { get; } = new List<Tree>();


        public Tree(string text)
        {
            Name = GetNextUniqueName();
            Text = text;
        }


        public void AddChild(string nodeText)
        {
            Nodes.Add(new Tree(nodeText));
        }

        //public bool TryGetAction(string nodeName, out Action action)
        //{
        //    foreach (ActionTree node in this.Nodes)
        //    {
        //        if (node.Name == nodeName)
        //        {
        //            action = node.OnClickAction;
        //            return true;
        //        }
        //    }

        //    foreach (ActionTree node in this.Nodes)
        //    {
        //        if (node.Nodes.Count > 0)
        //        {
        //            if (node.TryGetAction(nodeName, out action))
        //            {
        //                return true;
        //            }
        //        }
        //    }

        //    action = () => { };
        //    return false;
        //}

        public override string ToString()
        {
            return this.Text;
        }

        private string GetNextUniqueName()
        {
            _id++;
            return $"Node_{ _id }";
        }
    }
}
