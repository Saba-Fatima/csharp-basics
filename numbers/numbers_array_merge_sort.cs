/*
 * Author : Saba Fatima
 *
 * Date : May 30, 2019
 *
*/

using System;

namespace NumberBasics {
	public class EvenOdd {
		static void Main(string[] args)
		{
			int n1, n2, n3,count=0;
			Console.WriteLine("Enter size of the array one:");
			n1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter size of the array two:");
			n2 = Convert.ToInt32(Console.ReadLine());
			int[] arr1 = new int[n1];
			int[] arr2 = new int[n2];
			int[] arr3 = new int[n1+n2];
			Console.WriteLine("Enter elements of  the array one:");
			for (int i = 0; i < n1; i++)
			{
				arr1[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("Enter elements of  the array two:");
			for (int i = 0; i < n2; i++)
			{
				arr2[i] = Convert.ToInt32(Console.ReadLine());
			}
			/*Merging 2 arrays into 3rd*/
			n3 = n1 + n2;
			for (int i = 0; i < n1; i++)
			{
				arr3[i] = arr1[i];
			}
			for (int j = 0; j < n2; j++)
			{
				arr3[j + n1] = arr2[j];
			}
			Console.WriteLine("bubble sorting the elements of the array in ascending order :");
			for (int i = 0; i < n3; i++)
			{
				for (int j = 0; j < n3-1; j++)
				{
					if (arr3[j] > arr3[j + 1])
					{
						count = arr3[j + 1];
						arr3[j + 1] = arr3[j];
						arr3[j] = count;
					}
				}
			}
			for (int i = 0; i < n3; i++)
			{
				Console.WriteLine(arr3[i]);
			}
		}
	}
}