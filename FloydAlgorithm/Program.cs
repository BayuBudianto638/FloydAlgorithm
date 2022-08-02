// See https://aka.ms/new-console-template for more information
using FloydAlgorithm;

var nums = new int[] { 3, 1, 3, 4, 2 };
var result = FindDuplicate.findDuplicate(nums);
var resultLinq = FindDuplicate.findDuplicateLinq(nums);
Console.WriteLine($"Result : {result} ");
Console.WriteLine($"Result Linq : { resultLinq}");
Console.ReadKey();

