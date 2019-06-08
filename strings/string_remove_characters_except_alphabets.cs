#region Remove Characters in String Except Alphabets without using regex
string str = "", str2 = "";
Console.WriteLine("Enter your string here:");
str = Console.ReadLine();
for (int i = 0; i<str.Length-1; i++)
{
	if (((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 0 && str[i] <= 9)))
	{
		str2 = str2 + str[i]; 

	}
}
Console.WriteLine(str2);
Console.ReadLine();
#endregion