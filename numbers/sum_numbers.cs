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
			int number, remainder, sum = 0;
			Console.Write("Enter your Number here:");
			number = int.Parse(Console.ReadLine());
			while (number > 0)
			{
				remainder = number % 10;
				sum = sum + remainder;
				number = number / 10;
			}
			Console.Write(sum);
		}
	}
}