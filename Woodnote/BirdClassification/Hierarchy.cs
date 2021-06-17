using BirdClassification.AuxModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdClassification
{
    public class Hierarchy
    {
        private Tree _hierarchy;


        public Hierarchy()
        {
            _hierarchy = new Tree("Birds");
            _hierarchy.AddChild(Clade.Palaeognathae);
            _hierarchy.Nodes.Last().AddChild(Order.Apterygiformes);
            _hierarchy.Nodes.Last().AddChild(Order.Casuariiformes);
            _hierarchy.Nodes.Last().AddChild(Order.Rheiformes);
            _hierarchy.Nodes.Last().AddChild(Order.Struthioniformes);
            _hierarchy.Nodes.Last().AddChild(Order.Tinamiformes);
            // Вымершие:
            _hierarchy.Nodes.Last().AddChild(Order.Aepyornithiformes);
            _hierarchy.Nodes.Last().AddChild(Order.Lithornithiformes);
            _hierarchy.Nodes.Last().AddChild(Order.Dinornithiformes);

            _hierarchy.AddChild(Clade.Neognathae);
            _hierarchy.Nodes.Last().AddChild("");
            _hierarchy.Nodes.Last().AddChild("");
            _hierarchy.Nodes.Last().AddChild("");
        }
    }
}
