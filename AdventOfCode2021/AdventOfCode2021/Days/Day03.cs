using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2021.Days
{
	internal class Day03 : IDay
	{
		public string SolvePart1(string[] input)
		{
			try
			{
				string gammaBinary = "";
				string epsilonBinary = "";

				for (int i = 0; i < input[0].Length; i++)
				{
					var ones = 0;
					var zeroes = 0;
					foreach (var binNumber in input)
					{
						if (binNumber[i] == '0')
							zeroes++;
						else if (binNumber[i] == '1')
							ones++;
					}
					if (zeroes > ones)
					{
						gammaBinary += "0";
						epsilonBinary += "1";
					}
					else
					{
						gammaBinary += "1";
						epsilonBinary += "0";
					}
				}

				var gammaDec = BinaryToDecimal(gammaBinary);
				var epsilonDec = BinaryToDecimal(epsilonBinary);

				var power = gammaDec * epsilonDec;

				return power.ToString();
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
				var oxygenBinary = OxygenRating(input);
				var oxygenDec = BinaryToDecimal(oxygenBinary);

				var scrubberBinary = ScrubberRating(input);
				var scrubberDec = BinaryToDecimal(scrubberBinary);

				return (oxygenDec * scrubberDec).ToString();
			}
			catch (Exception ex)
			{
				return $"Could not find answer: {ex.Message}";
			}
		}

		private int BinaryToDecimal(string binaryVal)
		{
			try
			{
				var decVal = 0;
				for (int i = 0; i < binaryVal.Length; i++)
				{
					decVal += (int)(int.Parse($"{binaryVal[i]}") * MathF.Pow(2, (binaryVal.Length - i - 1)));
				}
				return decVal;
			}
			catch (Exception ex)
			{
				throw new Exception("Could not convert to decimal", ex);
			}
		}

		private string OxygenRating(string[] report)
		{
			var tempList = report.ToList();
			var bitIndex = 0;
			while (tempList.Count > 1)
			{
				var maxValues = tempList.Select(x => int.Parse(x.Substring(bitIndex, 1))).OrderBy(x => x).TakeLast((int)MathF.Ceiling((float)tempList.Count / 2)).ToList();
				var mostCommon = maxValues.ElementAt(0);
				tempList = tempList.Where(x => int.Parse(x.Substring(bitIndex, 1)) == mostCommon).ToList();
				bitIndex++;
			}
			return tempList[0];
		}

		private string ScrubberRating(string[] report)
		{
			var tempList = report.ToList();
			var bitIndex = 0;
			while (tempList.Count > 1)
			{
				var maxValues = tempList.Select(x => int.Parse(x.Substring(bitIndex, 1))).OrderBy(x => x).TakeLast((int)MathF.Ceiling((float)tempList.Count / 2)).ToList();
				var mostCommon = maxValues.ElementAt(0);
				tempList = tempList.Where(x => int.Parse(x.Substring(bitIndex, 1)) != mostCommon).ToList();
				bitIndex++;
			}
			return tempList[0];
		}
	}
}
