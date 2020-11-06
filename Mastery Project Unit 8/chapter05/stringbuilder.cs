using System;
 	using System.Text;
 	public class MyApp
	{		 
	  static void Main() 	 
	  {
		Console.WriteLine("String routine");
		string a = "a";
		string str = string.Empty;
		int istart, istop;
		istart = Environment.TickCount;
		Console.WriteLine("Start: "+istart);
		// Use regular C# concatenation operator
		for(int i=0; i<50000; i++)
		{
		  str += a;
		}
		istop = Environment.TickCount;
		Console.WriteLine("Stop: "+istop);
		Console.WriteLine("Difference: " + (istop-istart));	
		// Perform concatenation with StringBuilder	
		Console.WriteLine("StringBuilder routine");
		StringBuilder builder = new StringBuilder();
		istart = Environment.TickCount;
		Console.WriteLine("Start: "+istart);
		for(int i=0; i<50000; i++)
		{
		  builder.Append(a);
		}
		istop = Environment.TickCount;
		str = builder.ToString();
		Console.WriteLine("Stop: "+Environment.TickCount);
		Console.WriteLine("Difference: "+ (istop-istart));	
	  } 
	}
