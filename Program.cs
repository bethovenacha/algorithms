using System.Text.Json;
using DataStructuresAndAlgorithms.Arrays;
using DataStructuresAndAlgorithms.Trees;


/*
int[] input = new int[] { 4, 6, 1, -3 };
int target = 3;
var result  = Arrays.TwoNumberSum(input, target);
Console.WriteLine($"[{string.Join(", ", result)}]");
*/

/*
 SORTED SQUARRED ARRAY
    Given an array of integers, return the squares of the integers in a sorted order
int[] input = new int[] { 1,2,3,5,6,8,9};
var result = Arrays.SortedSquaredArray(input);
Console.WriteLine($"[{string.Join(", ", result)}]");
*/

/*
 * VALID SUB SEQUENCE
int[] input = [5, 1, 22, 25, 6, -1, 8, 10];
int[] sequence = [1, 6, -1, 10];

var result = Arrays.IsValidSubsequence(input.ToList(), sequence.ToList());
Console.WriteLine("The sequence is a subsequence: " + result); 
 */


/* TOURNAMENT WINNER
var competitions = new List<List<string>> {
            new List<string>{"HTML","C#"},
            new List<string>{"C#","PYTHON"},
            new List<string>{"PYTHON","HTML"}
        };
var results = new List<int> { 0, 0, 1 };

var winner = Arrays.TournamentWinner(competitions, results);
Console.WriteLine(winner);
*/

/*
 * NON CONSTRUCTIBLE CHANGE
 int [] coins = new int[]{1,2,5};
var result = Arrays.NonConstructibleChange(coins);
Console.WriteLine(result);
*/

/*
 * FINDING THE CLOSEST VALUE IN A BINARY SEARCH TREE
string json = @"{
  ""tree"": {
    ""nodes"": [
      {""id"": ""10"", ""left"": ""5"", ""right"": ""15"", ""value"": 10},
      {""id"": ""15"", ""left"": ""13"", ""right"": ""22"", ""value"": 15},
      {""id"": ""22"", ""left"": null, ""right"": null, ""value"": 22},
      {""id"": ""13"", ""left"": null, ""right"": ""14"", ""value"": 13},
      {""id"": ""14"", ""left"": null, ""right"": null, ""value"": 14},
      {""id"": ""5"", ""left"": ""2"", ""right"": ""5-2"", ""value"": 5},
      {""id"": ""5-2"", ""left"": null, ""right"": null, ""value"": 5},
      {""id"": ""2"", ""left"": ""1"", ""right"": null, ""value"": 2},
      {""id"": ""1"", ""left"": null, ""right"": null, ""value"": 1}
    ],
    ""root"": ""10""
  },
  ""target"": 12
}";

var (tree, target) = BstBuilder.BuildFromJson(json);

int closest = Trees.FindClosestValueInBst(tree, target);
Console.WriteLine(closest); // 13

*/

/*
 * SUMMING BRANCH VALUES -> DATA ONLY
 
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;\

public class BinaryTree
{
    public int Value;
    public BinaryTree Left;
    public BinaryTree Right;

    public BinaryTree(int value)
    {
        Value = value;
    }
}


public class TreeWrapper
{
    public Tree Tree { get; set; }
}

public class Tree
{
    public List<NodeData> Nodes { get; set; }
    public string Root { get; set; }
}

public class NodeData
{
    public string Id { get; set; }
    public string Left { get; set; }
    public string Right { get; set; }
    public int Value { get; set; }
}

public static class TreeBuilder
{
    public static BinaryTree BuildTreeFromJson(string json)
    {
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        TreeWrapper wrapper = JsonSerializer.Deserialize<TreeWrapper>(json, options);
        Tree tree = wrapper.Tree;

        // Step 1: Create all nodes
        Dictionary<string, BinaryTree> nodeMap = new();

        foreach (var node in tree.Nodes)
        {
            nodeMap[node.Id] = new BinaryTree(node.Value);
        }

        // Step 2: Link left and right children
        foreach (var node in tree.Nodes)
        {
            BinaryTree current = nodeMap[node.Id];

            if (node.Left != null)
            {
                current.Left = nodeMap[node.Left];
            }

            if (node.Right != null)
            {
                current.Right = nodeMap[node.Right];
            }
        }

        // Step 3: Return root
        return nodeMap[tree.Root];
    }
}
EXAMPLE USAGE 
string json = @"{
  ""tree"": {
    ""nodes"": [
      {""id"": ""1"", ""left"": ""2"", ""right"": ""3"", ""value"": 1},
      {""id"": ""2"", ""left"": ""4"", ""right"": ""5"", ""value"": 2},
      {""id"": ""3"", ""left"": ""6"", ""right"": ""7"", ""value"": 3},
      {""id"": ""4"", ""left"": ""8"", ""right"": ""9"", ""value"": 4},
      {""id"": ""5"", ""left"": ""10"", ""right"": null, ""value"": 5},
      {""id"": ""6"", ""left"": null, ""right"": null, ""value"": 6},
      {""id"": ""7"", ""left"": null, ""right"": null, ""value"": 7},
      {""id"": ""8"", ""left"": null, ""right"": null, ""value"": 8},
      {""id"": ""9"", ""left"": null, ""right"": null, ""value"": 9},
      {""id"": ""10"", ""left"": null, ""right"": null, ""value"": 10}
    ],
    ""root"": ""1""
  }
}";

BinaryTree root = TreeBuilder.BuildTreeFromJson(json);

// Now you can call:
List<int> sums = Program.BranchSums(root);


*/

/*
 EVALUATE EXPRESSION TREE

Youre given a binary expression tree. Write a function to evalue this tree
mathematically and return a single integer.

All leaf nodes represent operands which will always be positive integers.
All the other nodes represent operators. 

-1: +
-2: -
-3: /
-4: *

 {
  "tree": {
    "nodes": [
      {"id": "1", "left": "2", "right": "3", "value": -1},
      {"id": "2", "left": null, "right": null, "value": 2},
      {"id": "3", "left": null, "right": null, "value": 3}
    ],
    "root": "1"
  }
}
 */

/*
 DEPTH FIRST SEARCH

Youre given a NODE class that has a name and and array of children nodes.
When put together, nodes form an acyclic tree like stucture.
Implement the DFS method on the node class, which takes in an empty array,
traverses the tree in a DFS (specifically navigating the tree from left to right),
store the node names in an input array, and return it.



string json = @"
{
  ""graph"": {
    ""nodes"": [
      { ""children"": [""B"", ""C"", ""D""], ""id"": ""A"", ""value"": ""A"" },
      { ""children"": [""E"", ""F""], ""id"": ""B"", ""value"": ""B"" },
      { ""children"": [], ""id"": ""C"", ""value"": ""C"" },
      { ""children"": [""G"", ""H""], ""id"": ""D"", ""value"": ""D"" },
      { ""children"": [], ""id"": ""E"", ""value"": ""E"" },
      { ""children"": [""I"", ""J""], ""id"": ""F"", ""value"": ""F"" },
      { ""children"": [""K""], ""id"": ""G"", ""value"": ""G"" },
      { ""children"": [], ""id"": ""H"", ""value"": ""H"" },
      { ""children"": [], ""id"": ""I"", ""value"": ""I"" },
      { ""children"": [], ""id"": ""J"", ""value"": ""J"" },
      { ""children"": [], ""id"": ""K"", ""value"": ""K"" }
    ],
    ""startNode"": ""A""
  }
}";


GraphWrapper wrapper = JsonSerializer.Deserialize<GraphWrapper>(json);

// Step 1: Create Node objects
var nodeMap = new Dictionary<string, Node>();

foreach (var n in wrapper.graph.nodes)
{
    nodeMap[n.id] = new Node(n.value);
}

// Step 2: Wire up children
foreach (var n in wrapper.graph.nodes)
{
    var currentNode = nodeMap[n.id];

    foreach (var childId in n.children)
    {
        currentNode.children.Add(nodeMap[childId]);
    }
}

// Step 3: DFS from start node
var start = nodeMap[wrapper.graph.startNode];
var result = start.DepthFirstSearch(new List<string>());

Console.WriteLine(string.Join(" -> ", result));

public class GraphWrapper
{
    public Graph graph { get; set; }
}

public class Graph
{
    public List<GraphNode> nodes { get; set; }
    public string startNode { get; set; }
}

public class GraphNode
{
    public string id { get; set; }
    public string value { get; set; }
    public List<string> children { get; set; }
}

 */




