using System;

namespace Tutorial
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "SNUcoder";
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.WindowHeight = 40;
			Console.WindowWidth = 40;

			Console.WriteLine("Hello, what's your name?");

			Console.ReadLine();
			
			Console.WriteLine("I am ATeX your friendly assistant\n I was made by ATeXTeam in 2060");
			Console.WriteLine("\n\nWhat is your favourite food?");
			
			Console.ReadLine();

			Console.WriteLine("Tasty! Mine is chocolate with a  pinch of RAM (only a little bit of RAM)");

			Console.ReadLine();
		}
	}
}
