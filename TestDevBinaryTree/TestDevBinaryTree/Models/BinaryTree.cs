using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDevBinaryTree.Models
{
    public class BinaryTree
    {
        public Node root;

        public BinaryTree(int key)
        {
            root = new Node(key);
        }

        public BinaryTree()
        {
            root = null;
        }
    }
}
