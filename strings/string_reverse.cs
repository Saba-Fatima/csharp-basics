/*
 * Author : Saba Fatima
 *
 * Date : May 20, 2019
 *
*/

using System;

namespace StringBasics {
	public class StringReverse {
		static void Main(string[] args)
		{

			/* Reverse  a String without using inbuilt function */

			string str = "";
			string reverse = "";
			int length;
			Console.WriteLine("enter your string here:");
			str = Console.ReadLine();
			length = str.Length - 1;
			while (length >= 0)
			{
				reverse = reverse + str[length];
				length--;
			}
			Console.WriteLine(reverse);
			int num = 12345678;
			int rev = 0, sum = 0;
			while (num>0)
			{
				rev = num % 10;
				sum = sum * 10 + rev;
				num = num / 10;
			}
			Console.WriteLine(sum);
			Console.ReadLine();
		}
	}
}
