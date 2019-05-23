/*
 * Author : Saba Fatima
 *
 * Date : May 23, 2019
 *
*/

using System;

namespace StringBasics {
	public class RemoveNonAlpha {
		static void Main(string[] args)
		{
			// Remove all Characters in a String Except Alphabet using regex
			string str = "";
			Console.WriteLine("Enter your string here:");
			str = Console.ReadLine();
			string numberOnly = Regex.Replace(str, @"[^0-9a-zA-Z]+", " ");
			Console.WriteLine(numberOnly);
			string convert = Regex.Replace(numberOnly, @"[\d-]", "");
			Console.WriteLine(convert);
		}
	}
}