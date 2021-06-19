using System.Collections.Generic;
using System.Linq;

namespace BirdClassification.BiologyClassification
{
    public class Hierarchy
    {
        private Tree _hierarchy;


        public Hierarchy()
        {
            _hierarchy = new Tree(BiologyClass.Birds);
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
            _hierarchy.Nodes.Last().AddChild(Superorder.Galloanseres);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Anseriformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Galliformes);
            _hierarchy.Nodes.Last().AddChild(Superorder.Neoaves);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Eurypygiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Ciconiiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Procellariiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Passeriformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Gaviiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Opisthocomiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Columbiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Otidiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Piciformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Gruiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Cariamiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Caprimulgiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Cuculiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Leptosomiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Mesitornithiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Suliformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Pelecaniformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Sphenisciformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Podicipediformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Psittaciformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Coliiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Bucerotiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Coraciiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Charadriiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Pterocliformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Strigiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Falconiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Apodiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Trogoniformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Musophagiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Phaethontiformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Phoenicopteriformes);
            _hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.Accipitriformes);
            //_hierarchy.Nodes.Last().Nodes.Last().AddChild(Order.);
        }


        public List<System.Enum> GetUpperHierarchy(System.Enum element)
        {
            return _hierarchy.GetAllParentNodes(element);
        }
    }
}
