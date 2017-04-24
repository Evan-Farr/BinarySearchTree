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
        private Node<T> children;
        private Node<T> nodeLeft;
        private Node<T> nodeRight;

        public T NodeValue { get { return nodeValue; } set { nodeValue = value; } }
        public Node<T> Parent { get { return parent; } }
        public Node<T> Children { get { return children; } set { children = value; } }
        public Node<T> NodeLeft { get { return nodeLeft; } set { nodeLeft = value; } }
        public Node<T> NodeRight { get { return nodeRight; } set { nodeRight = value; } }

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
