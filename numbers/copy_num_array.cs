/*
 * Author : Saba Fatima
 *
 * Date : May 28, 2019
 *
*/

using System;

namespace NumberBasics {
	public class CopyNumberArray {
		static void Main(string[] args)
		{
			int n;
			Console.WriteLine("Enter size of the array:");
			n = Convert.ToInt32(Console.ReadLine());
			int[] a = new int[n];
			int[] b = new int[n];
			Console.WriteLine("Elements of the array:");
			for (int i = 0; i < n; i++)
			{
				a[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("Elements of the array copied are:");
			for (int i = 0; i < n; i++)
			{
				b[i] = a[i];
				Console.WriteLine(b[i]);
			}
		}
	}
}