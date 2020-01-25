using System;

public class Values
{
	internal static double[][] matrix = Arrays.RectangularDoubleArray(Constants.numberOfTimeIterations + 1, Constants.numberOfXIterations + 1);

	internal static void calculate()
	{
		for (int t = 0; t < Constants.numberOfTimeIterations + 1; t++)
		{
			for (int i = 0; i < Constants.numberOfXIterations + 1; i++)
			{
				matrix[t][i] = Math.Pow(Constants.c0 * Constants.xStep * i - Constants.a * Constants.c1 * t * Constants.timeStep + Constants.c2, -1);
			}
		}
	}
}
