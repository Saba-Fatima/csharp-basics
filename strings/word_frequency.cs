/*
 * Author : Saba Fatima
 *
 * Date : May 21, 2019
 *
*/

using System;

namespace StringBasics {
	public class StringReverse {
		static void Main(string[] args)
		{
			/* Frequency of characters in a string */
			string str1 = "saba";
			Console.WriteLine("Enter your input here:");
			string str2 = Console.ReadLine();
			int count = 0;
			string s = "";
			int length = str2.Length;
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length; j++)
				{
					if (str2[i]==str2[j])
					{
						count++;
						s =str2[j].ToString();

					}

				}

				Console.WriteLine(s + '-' + count);
				count = 0;

			}
		}
	}
}