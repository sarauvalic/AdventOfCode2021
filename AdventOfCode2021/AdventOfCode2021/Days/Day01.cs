namespace AdventOfCode2021.Days
{
	internal class Day01 : IDay
	{
		public string SolvePart1(string[] input)
		{
			try
			{
				var increases = 0;
				var prevDepth = int.MaxValue;
				for (int i = 0; i < input.Length; i++)
				{
					var depth = int.Parse(input[i]);
					if (depth > prevDepth)
						increases++;
					prevDepth = depth;
				}
				return increases.ToString();
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
				var increases = 0;
				var prevDepthSum = int.MaxValue;
				for (int i = 1; i < input.Length - 1; i++)
				{
					var depthSum = int.Parse(input[i]) + int.Parse(input[i - 1]) + int.Parse(input[i + 1]);
					if (depthSum > prevDepthSum)
						increases++;
					prevDepthSum = depthSum;
				}
				return increases.ToString();
			}
			catch (Exception)
			{
				return "Could not find answer";
			}
		}
	}
}