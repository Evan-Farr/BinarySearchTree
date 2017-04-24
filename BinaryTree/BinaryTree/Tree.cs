using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree<T> where T : IComparable
    {
        private int count;
        private Node<T> root;

        public int Count { get { return count; } set { count = value; } }
        public Node<T> Root { get { return root; } set { root = value; } }

        public Tree(Node<T> root)
        {
            this.root = root;
            count = 1;
        }

        public void Add(Node<T> node, T value)
        {
            if(value.CompareTo(node.NodeValue) == 0)
            {
                throw new Exception("Unable to add because this value already exists in the tree.");
            }else if(value.CompareTo(node.NodeValue) < 0)
            {
                if(node.LeftChild == null)
                {
                    node.LeftChild = new Node<T>(value);
                }else
                {
                    Add(node.LeftChild, value);
                }
            }else
            {
                if(node.RightChild == null)
                {
                    node.RightChild = new Node<T>(value);
                }else
                {
                    Add(node.RightChild, value);
                }
            }
        }

        public void Search(T value)
        {
            var startPoint = root;
        }
    }
}
