using NUnit.Framework;
using System.Linq;

namespace BirdClassification.Tests
{
    [TestFixture]
    public class TreeTests
    {
        private Tree _tree;

        [SetUp]
        public void Setup()
        {
            _tree = new Tree(TestEnum.One);
            _tree.AddChild(TestEnum.Two);
            _tree.Nodes.Last().AddChild(TestEnum.Three);
            _tree.Nodes.Last().AddChild(TestEnum.Four);
        }

        [Test]
        public void FirstNode_GetAllParentNodes_CorrectNodes()
        {
            var nodes = _tree.GetAllParentNodes(TestEnum.One);
            Assert.AreEqual(0, nodes.Count());
        }

        [Test]
        public void SecondNode_GetAllParentNodes_CorrectNodes()
        {
            var nodes = _tree.GetAllParentNodes(TestEnum.Two);
            Assert.AreEqual(1, nodes.Count());
            Assert.AreEqual(TestEnum.One, nodes.ElementAt(0));
        }

        private enum TestEnum
        {
            One,
            Two,
            Three,
            Four
        }
    }
}