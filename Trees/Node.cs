using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.Trees
{
    public class Node
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("children")]
        public List<Node> Children { get; set; } = new();

        public Node(string name)
        {
            this.Name = name;
        }
    }
}
