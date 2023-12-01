using aoc2023.Helpers;

var i1 = File.ReadAllLines("./Inputs/1.txt");
var i1p1 = i1
    .Select(p => p.Advent1GetIntFromNoisyString())
    .Sum();
var i1p2 = i1
    .Select(p => p.Advent1GetIntFromNoisyString(true))
    .Sum();
Console.WriteLine("Result for input 1 part 1 : {0}", i1p1);
Console.WriteLine("Result for input 1 part 2 : {0}", i1p2);
