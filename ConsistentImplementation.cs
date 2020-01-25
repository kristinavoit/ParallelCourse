using System;

//Consistent implementation of explicit method

public class ConsistentImplementation
{
	internal static double[][] matrix = Arrays.RectangularDoubleArray(Constants.numberOfTimeIterations + 1, Constants.numberOfXIterations + 1);
	internal static int finalT;
	internal virtual void calculate()
	{
		//t=0
		for (int i = 0; i < Constants.numberOfXIterations + 1; i++)
		{
			matrix[0][i] = Math.Pow(Constants.c0 * Constants.xStep * i + Constants.c2, -1);
		}
		//x=0, x=1
		for (int t = 1; t < Constants.numberOfTimeIterations + 1; t++)
		{
			matrix[t][0] = Math.Pow(-Constants.a * Constants.c1 * t * Constants.timeStep + Constants.c2, -1);
			matrix[t][Constants.numberOfXIterations] = Math.Pow(Constants.c0 - Constants.a * Constants.c1 * t * Constants.timeStep + Constants.c2, -1);
		}
		long beginTime = TimeHelper.TimeMillis(); 
		for (int t = 0; t < Constants.numberOfTimeIterations ; t++)
		{
			for (int i = 1; i < Constants.numberOfXIterations ; i++)
			{
				matrix[t + 1][i] = Constants.a * Constants.timeStep * (2 * matrix[t][i] * (matrix[t][i - 1] - 2 * matrix[t][i] + matrix[t][i + 1]) - Constants.xStep * Math.Pow(matrix[t][i + 1] - matrix[t][i - 1], 2)) / (2 * Math.Pow(Constants.xStep * matrix[t][i], 2)) + matrix[t][i];
			}
		}
		long endTime = TimeHelper.TimeMillis();
	}
}
