/*
 * Author : Saba Fatima
 *
 * Date : May 28, 2019
 *
*/

using System;

namespace NumberBasics {
	public class ArrayAverage {
		static void Main(string[] args)
		{
			int[] a = new int[100];
			int average=0, n;
			Console.WriteLine("Enter length of the array:");
			n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter elements of the array:");
			for (int i = 0; i < n; i++)
			{
				a[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("Average of the array elements:");
			for (int i = 0; i < n; i++)
			{
				average = (average + a[i]);
			}
			Console.WriteLine(average / n);
		}
	}
}