/*
 * Author : Saba Fatima
 *
 * Date : May 26, 2019
 *
*/

using System;

namespace NumberBasics {
	public class SumNumber {
		static void Main(string[] args)
		{
			int a=5, b=10;
			a = a + b;
			b = b - a;
			a = a - b;
			Console.WriteLine(a+" "+b);
		}
	}
}