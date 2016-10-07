using NUnit.Framework;

namespace KatasAndExercises.Algorithms
{
    public class BinarySearchTree
    {
        public TreeNode Root { get; private set; }

        public void Insert(int value)
        {
            Root = Insert(Root, value);
        }

        private static TreeNode Insert(TreeNode node, int value)
        {
            if (node == null)
            {
                return new TreeNode {Value = value};
            }
        
            if (node.Value == value)
            {
                return node;
            }

            if (value > node.Value)
            {
                node.Right = Insert(node.Right, value);
            }
            else
            {
                node.Left = Insert(node.Left, value);
            }

            return node;
        }

        public bool Search(int value)
        {
            return Search(Root, value);
        }

        private bool Search(TreeNode node, int value)
        {
            if (node == null)
                return false;
            if (value == node.Value)
                return true;

            if (value > node.Value)
            {
                return Search(node.Right, value);
            }
            return Search(node.Left, value);
        }

        public void Delete(int value)
        {
            
        }
    }

    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
    }

    [TestFixture]
    public class BinarySearchTreeTests
    {
        [Test]
        public void when_values_are_ordered_on_insert_all_values_are_on_right_nodes()
        {
            var number = new[]{1,2,3,4,5};

            var binarySearchTree = new BinarySearchTree();

            for (int i = 0; i < number.Length; i++)
            {
                binarySearchTree.Insert(number[i]);
            }

            var current = binarySearchTree.Root;
            var nodeCount = 0;

            while (current != null)
            {
                if (current.Left != null)
                    Assert.Fail("Value was found on a left child");
                current = current.Right;
                nodeCount++;
            }
            Assert.That(nodeCount, Is.EqualTo(number.Length));
        }

        [Test]
        public void when_searching_and_value_is_in_the_tree_returns_true()
        {
            var binarySearchTree = CreatePopulatedTree();

            Assert.That(binarySearchTree.Search(3), Is.True);
        }

        [Test]
        public void when_searching_and_value_is_not_in_the_tree_returns_false()
        {
            var binarySearchTree = CreatePopulatedTree();

            Assert.That(binarySearchTree.Search(12), Is.False);
        }

        private BinarySearchTree CreatePopulatedTree()
        {
            var number = new[] { 1, 3, 8, 4, 15 };

            var binarySearchTree = new BinarySearchTree();

            for (int i = 0; i < number.Length; i++)
            {
                binarySearchTree.Insert(number[i]);
            }

            return binarySearchTree;
        }
    }
}
