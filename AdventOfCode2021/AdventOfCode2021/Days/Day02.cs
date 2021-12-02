using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Days
{
	internal class Day02 : IDay
	{
		public string SolvePart1(string[] input)
		{
			try
			{
				var horizontal = 0;
				var depth = 0;

				foreach (var line in input)
				{
					var parts = line.Split(" ");
					var units = int.Parse(parts[1]);
					switch (parts[0])
					{
						case "forward":
							horizontal += units;
							break;
						case "down":
							depth += units;
							break;
						case "up":
							depth -= units;
							break;
						default:
							break;
					}
				}
				var result = horizontal * depth;

				return result.ToString();
			}
			catch (Exception ex)
			{
				return $"Could not find answer: {ex.Message}";
			}
		}

		public string SolvePart2(string[] input)
		{
			try
			{
				var horizontal = 0;
				var depth = 0;
				var aim = 0;

				foreach (var line in input)
				{
					var parts = line.Split(" ");
					var units = int.Parse(parts[1]);
					switch (parts[0])
					{
						case "forward":
							horizontal += units;
							depth += aim * units;
							break;
						case "down":
							aim += units;
							break;
						case "up":
							aim -= units;
							break;
						default:
							break;
					}
				}
				var result = horizontal * depth;

				return result.ToString();
			}
			catch (Exception ex)
			{
				return $"Could not find answer: {ex.Message}";
			}
		}
	}
}
