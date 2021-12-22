using System;

// Part 1 Solution: 1025636
// Part 2 Solution: ???
public class Day3
{
	
	public static void Main()
	{
		Part1();
		Part2();
	}

	public static void Part1()
	{
		long solution = 0;

		int[] counts = new int[12];
		int totalRows = 0;

		foreach (string s in input)
		{
			for (int i=0; i<12; i++)
			{
				counts[i] += s[i] == '1' ? 1 : 0;
			}
			totalRows += 1;
		}

		string gammaBinary = "";
		string epsilonBinary = "";

		foreach (int c in counts)
		{
			gammaBinary += (c > totalRows/2) ? '1' : '0';
			epsilonBinary += (c > totalRows/2) ? '0' : '1';
		}

		long gamma = Convert.ToInt64(gammaBinary, 2);
		long epsilon = Convert.ToInt64(epsilonBinary, 2);
		solution = gamma * epsilon;

		Console.WriteLine("Part 1 Solution: {0}", solution);
	}

	public static void Part2()
	{
		long solution = 0;

		Console.WriteLine("Part 2 Solution: {0}", solution);
	}

}