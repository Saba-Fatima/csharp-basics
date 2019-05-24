/*
 * Author : Saba Fatima
 *
 * Date : May 24, 2019
 *
*/

using System;

namespace NumbersBasics {
	public class CheckPrime {
		static void Main(string[] args)
		{
			// Check if number is a prime [Number which is divisible by 1 and itself]
			int n, i, m=0, flag=0;    
			Console.Write("Enter the Number to check Prime: ");    
			n = int.Parse(Console.ReadLine());  
			m=n/2; // No factor of a number will be greater than half of itself
			for(i = 2; i <= m; i++) { // Loop to check factors [starting at 2 as 1 is always a factor of everything]
				if(n % i == 0) { // checking if divisible by `i`
				 Console.Write("Number is not Prime.");    
				 flag=1;
				 break;    
				}    
			}
			if (flag==0)
				Console.Write("Number is Prime.");
		}
	}
}