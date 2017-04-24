using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node<T> where T : IComparable
    {
        private T nodeValue;
        private Node<T> parent;
        private Node<T> leftChild;
        private Node<T> rightChild;

        public T NodeValue { get { return nodeValue; } set { nodeValue = value; } }
        public Node<T> Parent { get { return parent; } set { parent = value; } }
        public Node<T> LeftChild { get { return leftChild; } set { leftChild = value; } }
        public Node<T> RightChild { get { return rightChild; } set { rightChild = value; } }

        public Node(T nodeValue)
        {
            this.nodeValue = nodeValue;
        }

        public override string ToString()
        {
            return nodeValue.ToString();
        }
    }
}
