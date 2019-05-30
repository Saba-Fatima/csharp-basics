/*
 * Author : Saba Fatima
 *
 * Date : May 30, 2019
 *
*/

using System;

namespace NumberBasics {
	public class EvenOdd {
		static void Main(string[] args)
		{
			int n, count = 0;
			Console.WriteLine("enter size of the array here:");
			n = Convert.ToInt32(Console.ReadLine());
			int[] arr1 = new int[n];
			Console.WriteLine("Enter elements of the array here:");
			for (int i = 0; i < n; i++)
			{
				arr1[i] = Convert.ToInt32(Console.ReadLine());
			}
			for (int i = 0; i <= n; i++)
			{

				if (arr1[i] % 2 == 0)
				{
					Console.WriteLine("even elements of the array:");
					Console.WriteLine(arr1[i]);
				}
				else if (arr1[i] % 2 != 0)
				{
					Console.WriteLine("odd elements of the array:");
					Console.WriteLine(arr1[i]);
				}

			}
		}
	}
}