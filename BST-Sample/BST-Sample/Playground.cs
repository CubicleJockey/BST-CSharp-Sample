using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using BST_Sample.BinarySearchTree;
using FluentAssertions;

namespace BST_Sample
{
    [TestClass]
    public class Playground
    {
        [TestMethod]
        public void Add()
        {
            //Arrange
            IEnumerable<int> numbers = Enumerable.Range(1, 8);
            ICollection<bool> addResults = new List<bool>();
            ITree tree = new Tree();
            
            //Act
            foreach (var number in numbers)
            {
                addResults.Add(tree.Add(number));
            }
            
            //Assert
            tree.NodeCount.Should().Be(8);
            addResults.All(result => result).Should().BeTrue();
        }
    }
}
