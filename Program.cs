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


