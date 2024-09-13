// See https://aka.ms/new-console-template for more information

using ArraysAndHashing = LeetCodeCs.ArraysAndHashing.Problem;
using TwoPointers = LeetCodeCs.TwoPointers.Problem;

/*
int[][] testCases =
[
    [100, 4, 200, 1, 3, 2],
    [0, 3, 7, 2, 5, 8, 4, 6, 0, 1],
    [1, 2, 0, 1],
    [0],
    [0, 0],
    []
];

foreach (var testCase in testCases)
{
    Console.WriteLine(ArraysAndHashing.LongestConsecutive(testCase));
}
*/

//Console.WriteLine(ArraysAndHashing.LongestConsecutive([100,4,200,1,3,2]));
foreach (var i in TwoPointers.TwoSum([2,7,11,15], 9))
{
    Console.WriteLine(i);
}
