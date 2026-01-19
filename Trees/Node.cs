using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Trees
{
    public class Node
    {
        public string name;
        public List<Node> children = new List<Node>();

        public Node(string name)
        {
            this.name = name;
        }

        public List<string> DepthFirstSearch(List<string> result)
        {
            result.Add(this.name);

            foreach (var child in children)
            {
                child.DepthFirstSearch(result);
            }

            return result;
        }
    }
}
