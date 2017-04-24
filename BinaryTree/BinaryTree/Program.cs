using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> bst = new Tree<int>();

            bst.Add(bst.Root, 20);
            bst.Add(bst.Root, 18);
            bst.Add(bst.Root, 35);
            bst.Add(bst.Root, 30);
            bst.Add(bst.Root, 10);
            bst.Add(bst.Root, 11);
            bst.Add(bst.Root, 8);

            bst.Search(18);
            bst.Search(8);
            bst.Search(3);
        }
    }
}
