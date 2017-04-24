using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree<T> where T : IComparable
    {
        private int count;
        private Node<T> root;

        public int Count { get { return count; } set { count = value; } }
        public Node<T> Root { get { return root; } set { root = value; } }

        public Tree()
        {
            count = 0;
        }

        public void Add(Node<T> node, T value)
        {
            if(root == null)
            {
                root = new Node<T>(value);
                count++;
            }else if(value.CompareTo(node.NodeValue) == 0)
            {
                throw new Exception("Unable to add because this value already exists in the tree.");
            }else if(value.CompareTo(node.NodeValue) < 0)
            {
                if(node.LeftChild == null)
                {
                    node.LeftChild = new Node<T>(value);
                    node.LeftChild.Parent = node;
                    count++;
                }
                else
                {
                    Add(node.LeftChild, value);
                }
            }else
            {
                if(node.RightChild == null)
                {
                    node.RightChild = new Node<T>(value);
                    node.RightChild.Parent = node;
                    count++;
                }
                else
                {
                    Add(node.RightChild, value);
                }
            }
        }

        public bool Search(T value)
        {
            var current = root;
            while (current != null)
            {
                if(current.NodeValue.Equals(value))
                {
                    return true;
                }
                current = value.CompareTo(current.NodeValue) < 0 ? current.LeftChild : current.RightChild;
            }
            return false;
        }
    }
}
