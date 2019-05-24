/*
 * Author : Saba Fatima
 *
 * Date : May 24, 2019
 *
*/

using System;

namespace NumbersBasics {
	public class Factorial {
		static void Main(string[] args)
		{
			// Calculate the factorial of a given number
			int i, number, fact;
			Console.WriteLine("Enter the Number");
			number = int.Parse(Console.ReadLine()); // Parsing to Int as input is taken as string
			fact = number;
			for (i = number - 1; i >= 1; i--)
			{
				fact = fact * i;
			}
			Console.WriteLine("\nFactorial of Given Number is: " + fact);
		}
	}
}