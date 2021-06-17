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
        public object Obj { get; }
        public List<Tree> Nodes { get; } = new List<Tree>();


        public Tree(object obj)
        {
            Name = GetNextUniqueName();
            Obj = obj;
        }


        public void AddChild(object obj)
        {
            Nodes.Add(new Tree(obj));
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

        private string GetNextUniqueName()
        {
            _id++;
            return $"Node_{ _id }";
        }
    }
}
