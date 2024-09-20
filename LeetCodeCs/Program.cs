// See https://aka.ms/new-console-template for more information

using ArraysAndHashing = LeetCodeCs.ArraysAndHashing.Problem;
using TwoPointers = LeetCodeCs.TwoPointers.Problem;



var cases = new List<(int result, int expected)>
{
    (TwoPointers.MaxArea([1,0,0,0,0,0,0,2,2]), 8),
    (TwoPointers.MaxArea([1, 8, 6, 2, 5, 4, 8, 3, 7]), 49),
    (TwoPointers.MaxArea([1,1]), 1),
    (TwoPointers.MaxArea([2,3,4,5,18,17,6]), 17)
};

cases.ForEach(x =>
{
    Console.WriteLine($"Case; Expected: {x.expected}; Actual: {x.result}; Result: {x.result == x.expected}");
});



