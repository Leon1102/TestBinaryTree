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
    public class AncestorController : ControllerBase
    {
        // POST api/BinaryTreeTest
        [HttpPost]
        public ActionResult<int> Post([FromBody] InputAncestor value)
        {
            Node resultNode = LowestCommonAncestor(value.tree.root, value.node1, value.node2);
            return resultNode.key;
        }

        public virtual Node LowestCommonAncestor(Node node, int n1, int n2)
        {
            if (node == null)
            {
                return null;
            }

            if (node.key > n1 && node.key > n2)
            {
                return LowestCommonAncestor(node.left, n1, n2);
            }

            if (node.key < n1 && node.key < n2)
            {
                return LowestCommonAncestor(node.right, n1, n2);
            }

            return node;
        }
    }
}