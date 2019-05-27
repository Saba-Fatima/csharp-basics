/*
 * Author : Saba Fatima
 *
 * Date : May 27, 2019
 *
*/

using System;

namespace NumberBasics {
	public class DecimalToBinary {
		static void Main(string[] args)
		{
			int n,remainder,div,i;
			int[] a = new int[10];
			Console.Write("Enter the number to convert: ");
			n = int.Parse(Console.ReadLine());
			for (i = 0; n>0; i++)
			{
				remainder = n % 2;
				a[i] = remainder;
				n = n / 2;
			}
			for (i = i-1; i>=0; i--)
			{
				Console.WriteLine(a[i]);
			}
		}
	}
}