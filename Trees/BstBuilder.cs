using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace DataStructuresAndAlgorithms.Trees
{
    public static class BstBuilder
    {
        public static (BST root, int target) BuildFromJson(string json)
        {
            // Parse JSON
            RootJson data = JsonSerializer.Deserialize<RootJson>(json);

            // Step 1: Create all BST nodes
            var map = new Dictionary<string, BST>();

            foreach (var node in data.tree.nodes)
            {
                map[node.id] = new BST(node.value);
            }

            // Step 2: Wire left / right pointers
            foreach (var node in data.tree.nodes)
            {
                BST current = map[node.id];

                if (node.left != null)
                {
                    current.left = map[node.left];
                }

                if (node.right != null)
                {
                    current.right = map[node.right];
                }
            }

            // Step 3: Return root + target
            return (map[data.tree.root], data.target);
        }
    }

}
