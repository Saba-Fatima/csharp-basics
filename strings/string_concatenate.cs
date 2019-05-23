/*
 * Author : Saba Fatima
 *
 * Date : May 23, 2019
 *
*/

using System;

namespace StringBasics {
	public class ConcatStrings {
		static void Main(string[] args)
		{
			// Concatenate Two Strings
			string str1 = "";
			Console.WriteLine("enter your first string here:");
			str1 = Console.ReadLine();
			string str2 = "";
			Console.WriteLine("enter your second string here:");
			str2 = Console.ReadLine();
			string concatenate = "";
			concatenate = str1 + str2;
			Console.WriteLine(concatenate);
		}
	}
}