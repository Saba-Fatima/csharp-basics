
			int number, remainder, sum = 0;
			Console.Write("Enter your string here:");
			number = int.Parse(Console.ReadLine());
			while (number > 0)
			{
				remainder = number % 10;
				sum = sum + remainder;
				number = number / 10;
			}
			Console.Write(sum);
			Console.ReadLine();
			
