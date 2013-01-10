using System;

class String_Operations
{
	static void read_input(string S)
	{
		int StrLen = S.Length;
		int LastNum = StrLen - 1;
		string LastStr = S.Substring(LastNum, 1);
		
		if(LastStr == ".") {
			Console.WriteLine("You have entered a declarative sentence.");
		}
		else if(LastStr == "?") {
			Console.WriteLine("You have entered an interrogatory sentence.");
		}
		else if(LastStr == "!") {
			Console.WriteLine("You have entered an exclamatory sentence.");
		}
		else {
			Console.WriteLine("You did not enter a sentence.");
			}
	} 
	
	static void name(string fullName)
	{	
		
		int x = fullName.IndexOf(" ");
		
		if(x == -1) {
			Console.WriteLine(fullName);
		}
	 	
	 	else {
	 	int l = fullName.Length;
	 	int L = l - x;
		
		string lastName = fullName.Substring(x, L);
		string firstName = fullName.Substring(0, x); 
		
		Console.WriteLine(lastName + ", " + firstName);
		}
		
	}
	
	static void Main()
	{
		Console.Write("Enter a sentence with proper grammar: ");
		string S = Console.ReadLine();
		read_input(S);
		Console.Write("Enter your first and last name or a name you go by: ");
		string fullName = Console.ReadLine();
		name(fullName);	
	}		
}