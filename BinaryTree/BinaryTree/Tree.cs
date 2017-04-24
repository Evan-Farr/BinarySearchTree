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
            if ()
            {
            }
        }

        public void Search(T value)
        {
            var startPoint = root;
        }
    }
}
