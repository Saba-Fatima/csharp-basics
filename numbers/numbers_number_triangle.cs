#region Number Triangle
int numberoflayer = 6, Space, Number;
Console.WriteLine("Print paramid");
for (int i = 1; i <= numberoflayer; i++) // Total number of layer for pramid  
{
	for (Space = 1; Space <= (numberoflayer - i); Space++) // Loop For Space  
		Console.Write(" ");
	for (Number = 1; Number <= i; Number++) //increase the value  
		Console.Write("*");
	for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
		Console.Write("*");
	Console.WriteLine();
}
Console.Read();
#endregion
