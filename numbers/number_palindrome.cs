/*
 * Author : Saba Fatima
 *
 * Date : May 24, 2019
 *
*/

using System;

namespace NumbersBasics {
	public class Palindrome {
		static void Main(string[] args)
		{
			// Calculate if the given number is palindrome
			int n, r, sum = 0, temp;
			Console.Write("Enter the Number: ");
			n = int.Parse(Console.ReadLine());
			temp = n;
			while (n > 0)
			{
				r = n % 10;
				sum = (sum * 10) + r;
				n = n / 10;
			}
			if (temp == sum) {
				Console.Write("Number is Palindrome.");
			} else {
				Console.Write("Number is not a Palindrome.");
			}
		}
	}
}