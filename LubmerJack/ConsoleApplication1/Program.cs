using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;


// Global variables create ?? How ??

namespace LubmerJack
{
	internal class Program
	{
		
		// definition global variables
		public static int days 	= 1;
		public static int timbers = 0;
		public static int logs 	= 3;
		public static int trees = 0;
		
		public static void Main(string[] args)
		{
			Console.Write("\n");
			Console.WriteLine("It's a year of 1500 and you live in a cottage. \nTry to survive. :-)");
			Console.Write("\n");
			
			
			// definition start Loop while 
			bool start_app = true;
			while (start_app)
			{
				Message();

				Menu();
				
				string selection = Console.ReadLine();
				Console.Write("\n");
				Random rnd = new Random(); // Initialization
				switch (selection)
				{
					// Cut down a tree.
					case"1":   
						int falled_threes = rnd.Next(1, 4); // creates a number between 1 and 3
						int falled_timbers = rnd.Next(2, 5); // creates a number between 2 and 4
					
						Console.WriteLine("You went to the wood and cut off {0} threes and you have {1} timbers.", falled_threes, falled_timbers);
						
						trees += falled_threes;
						timbers += falled_timbers;
						break;
					//Cut the timbers on the logs.
					case"2":
						if (timbers > 0)
						{
							int cut_timbers = timbers;
							cut_timbers = rnd.Next(2, 5);
							if (cut_timbers > timbers)
							{
								int old_timbers = timbers * 2;
								Console.WriteLine("You cut off {0} timbers on {1} logs.", timbers, old_timbers);
								logs += old_timbers;
								timbers = 0;
							}
							else
							{
								timbers -= cut_timbers;
								int cut_logs = cut_timbers * 2;
								Console.WriteLine("You cut off {0} timbers on {1} logs.", cut_timbers, cut_logs);

								logs += cut_logs;
							}
						}
						else
						{
							Console.WriteLine("You have no timbers.");
						}
						break;
					// Go sleep.
					case"3":
						Console.WriteLine("Go sleep.");
						break;
					// End simulation.
					case"4":
						Console.WriteLine("You are death.");
						start_app = false;
						break;
					default:
						Console.WriteLine("Invalid entry.");
						break;
				}


				Count();

			}	

		}


		public static void Menu()
		{
			// the user selects an option
			string line1 = "What do you do ?";
			string option1 = "(1) Cut down a tree.";
			string option2 = "(2) Cut the timbers on the logs.";
			string option3 = "(3) Go sleep.";
			string option4 = "(4) End simulation.";
			string option5 = "Enter your Selection: ";
			string separator = null;
			Console.Write("\n");

			for (int i = 0; i < Console.WindowWidth / (3 / 2.0); i++)
			{
				separator += "_";
			}
			
			Console.SetCursorPosition((Console.WindowWidth - line1.Length) / 2, Console.CursorTop);
			Console.WriteLine(line1);
			
			Console.SetCursorPosition((Console.WindowWidth - separator.Length) / 2, Console.CursorTop);
			Console.WriteLine(separator);
			
			Console.SetCursorPosition((Console.WindowWidth - separator.Length + 5) / 2, Console.CursorTop);
			Console.WriteLine(option1);
			
			Console.SetCursorPosition((Console.WindowWidth - separator.Length + 5) / 2, Console.CursorTop);
			Console.WriteLine(option2);
			
			Console.SetCursorPosition((Console.WindowWidth - separator.Length + 5) / 2, Console.CursorTop);
			Console.WriteLine(option3);
			
			Console.SetCursorPosition((Console.WindowWidth - separator.Length + 5) / 2, Console.CursorTop);
			Console.WriteLine(option4);
			
			Console.SetCursorPosition((Console.WindowWidth - separator.Length + 2) / 2, Console.CursorTop);
			Console.WriteLine(separator);
			
			Console.SetCursorPosition((Console.WindowWidth - option5.Length - 2) / 2, Console.CursorTop);
			Console.WriteLine(option5);

		}

		public static void Message()
		{
			// it write currently day, timber/s und log/s
			if (timbers > 1)
			{
				Console.WriteLine("Is {0} Day. In the hovel have you {1} timbers and {2} logs.", days, timbers, logs);
				Console.Write("\n");	
			}
			else
			{
				Console.WriteLine("Is {0} Day. In the hovel have you {1} timber and {2} log.", days, timbers, logs);
				Console.Write("\n");	
			}
		}

		public static void Count()
		{
				
			if (logs > 0)
			{
				Console.WriteLine("You sleep one day und you burned one log.");
				logs -= 1;
			}
			else
			{
				Console.WriteLine("You have no more logs and your freeze.");
			}
		}
	}
}
