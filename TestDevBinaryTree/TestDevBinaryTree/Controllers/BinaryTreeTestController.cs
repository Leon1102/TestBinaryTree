using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestDevBinaryTree.Models;

namespace TestDevBinaryTree.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BinaryTreeTestController : ControllerBase
    {
        // POST api/BinaryTreeTest
        [HttpPost]
        public ActionResult<BinaryTree> Post([FromBody] int[][] value)
        {
            BinaryTree tree = new BinaryTree();
            for (int i = 0; i < value.Length; i++)
            {
                int[] nodesNumbers = value[i];
                foreach (int item in nodesNumbers)
                {
                    tree.root = AddNodeRecursive(tree.root, item);
                }
            }
            return tree;
        }

        private Node AddNodeRecursive(Node current, int value)
        {
            if (current == null)
            {
                return new Node(value);
            }

            if (value < current.key)
            {
                current.left = AddNodeRecursive(current.left, value);
            }
            else if (value > current.key)
            {
                current.right = AddNodeRecursive(current.right, value);
            }
            return current;
        }
    }
}