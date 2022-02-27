using System;
namespace array_example2
{
	public class Program
	{
		public static void Main()
		{//single dimensional array
			int[] evenNums = new int[5];
			evenNums[0] = 2;
			evenNums[1] = 4;
			evenNums[2] = 6;
			evenNums[3] = 8;
			evenNums[4] = 10;


			Console.WriteLine(evenNums[0]);
			Console.WriteLine(evenNums[1]);
			Console.WriteLine(evenNums[2]);
			Console.WriteLine(evenNums[3]);
			Console.WriteLine(evenNums[4]);

			//two dimensional Array
			int[,] arr2d = new int[3, 2]{
								{1, 2},
								{3, 4},
								{5, 6}
							};

			Console.WriteLine(arr2d[0, 0]);
			Console.WriteLine(arr2d[0, 1]);
			Console.WriteLine(arr2d[1, 0]);
			Console.WriteLine(arr2d[1, 1]);
			Console.WriteLine(arr2d[2, 0]);
			Console.WriteLine(arr2d[2, 1]);

		}
	}
}