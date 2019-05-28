/*
 * Author : Saba Fatima
 *
 * Date : May 28, 2019
 *
*/

using System;

namespace NumberBasics {
	public class ReverseArray {
		static void Main(string[] args)
		{
			int n;
			Console.WriteLine("Enter length of the array:");
			n = int.Parse(Console.ReadLine());
			int[] a = new int[n];
			Console.WriteLine("Enter elements of the array:");
			for (int i = 0; i < n; i++)
			{
			a[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("elements of the array:");
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine(a[i]);
			}
			Console.WriteLine("reverse elements of the array:");
			for (int i = n-1; i >= 0 ; i--)
			{
				Console.WriteLine(a[i]);
			}
		}
	}
}