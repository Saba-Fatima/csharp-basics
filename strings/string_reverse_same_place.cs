/*
 * Author : Saba Fatima
 *
 * Date : May 20, 2019
 *
*/

using System;

namespace StringBasics {
	public class StringReverseSamePlace {
		static void Main(string[] args)
		{

			/* Reverse each word individually without changing its position in the sentence */

			string str = "Saba Fatima All The", rev = "", temp = "", temp1="";
			string[] str1 = new string[100];
			str1 = str.Split(' ');
			int length = str1.Length;
			for (int i = 0; i < length; i++)
			{
				string str2 = str1[i].ToString();
				for (int j = str2.Length - 1; j >= 0; j--)
				{
					rev = rev + str2[j];
				}
				temp = temp + " " + rev;
				rev = "";
			}

			for (int i = 0; i < str1.Length - 1; i++)
			{
				for (int j = 0; j < str1.Length; j++)
				{
					if (j + 2 <= str1.Length - 1)
					{
						temp1 = str1[j + 2];
						str1[j + 2] = str1[j];
						str1[j] = temp1;
					}
				}
			}
			for (int i = 0; i < str1.Length; i++)
			{
				Console.WriteLine(str1[i]);
			}
		}
	}
}
