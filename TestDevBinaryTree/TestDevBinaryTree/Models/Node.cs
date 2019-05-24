using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestDevBinaryTree.Models
{
    public class Node
    {
        public int key;
        public Node left, right;

        public Node(int item)
        {
            key = item;
            left = right = null;
        }
    }
}
