using AdventOfCode2021.Days;

Console.WriteLine("Advent of Code 2021");
var day = new Day03();
var input = File.ReadAllLines("C:\\C\\Repos\\AdventOfCode\\AdventOfCode2021\\AdventOfCode2021\\AdventOfCode2021\\Inputs\\Input03.txt");

Console.WriteLine("Part 1:");
Console.WriteLine(day.SolvePart1(input));

Console.WriteLine("Part 2:");
Console.WriteLine(day.SolvePart2(input));