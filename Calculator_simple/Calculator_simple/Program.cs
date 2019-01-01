using System;
using System.Security.Cryptography.X509Certificates;

namespace Calculator_simple
{
	internal class Program
	{

		public static int selection;
		public static double x;
		public static double y;
		public static double result;
		
		public static void Main(string[] args)
		{

			do
			{
				Menu();
							
				Control();

				switch (selection)
				{
					case 1:
						Numbers();
						result = x + y;
						Console.WriteLine("Result is {0}.", result);
						break;
					
					case 2:
						Numbers();
						result = x - y;
						Console.WriteLine("Result is {0}.", result);
						break;
					
					case 3:
						Numbers();
						result = x * y;
						Console.WriteLine("Result is {0}.", result);
						break;
	
					case 4:
						Numbers();
						if (y == 0)
						{
							Console.WriteLine("Cannot divide by zero! Please try again.");
						}
						else
						{
							result = x / y;
							Console.WriteLine("Result is {0}.", result);
						}
						break;
					
					case 5:
						Numbers();
						result = x % y;
						Console.WriteLine("Result is {0}.", result);
						break;
								
					default:
						Console.WriteLine("Invalid Input.");
						break;
						
				}
	
				
			} while ( selection != 0 );
			
			
			
		}
		
		public static void Menu()
		{
			// the user selects an option
			string line1 = "Hallo I'm your super Calculator.";
			string line2 = "What do you do ?";
			string option1 = "(1) Addition.";
			string option2 = "(2) Subtraktion.";
			string option3 = "(3) Multiplikation.";
			string option4 = "(4) Division.";
			string option5 = "(5) Modulo.";
			string option6 = "(0) Quit.";
			string option7 = "Enter your Selection: ";
			string separator = null;
			Console.Write("\n");

			for (int i = 0; i < Console.WindowWidth / (3 / 2.0); i++)
			{
				separator += "_";
			}
			
			Console.SetCursorPosition((Console.WindowWidth - line1.Length) / 2, Console.CursorTop);
			Console.WriteLine(line1);
			
			Console.SetCursorPosition((Console.WindowWidth - line2.Length) / 2, Console.CursorTop);
			Console.WriteLine(line2);
			
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
			
			Console.SetCursorPosition((Console.WindowWidth - separator.Length + 5) / 2, Console.CursorTop);
			Console.WriteLine(option5);
			
			Console.SetCursorPosition((Console.WindowWidth - separator.Length + 5) / 2, Console.CursorTop);
			Console.WriteLine(option6);
			
			Console.SetCursorPosition((Console.WindowWidth - separator.Length + 2) / 2, Console.CursorTop);
			Console.WriteLine(separator);
			
			Console.SetCursorPosition((Console.WindowWidth - option5.Length - 2) / 2, Console.CursorTop);
			Console.WriteLine(option7);
		}

		public static void Control()
		{
			try
			{
				selection = Convert.ToInt32(Console.ReadLine());
				if (selection >= 6)
				{
					Console.WriteLine("Invalid Input. Please try again.");
				}
			}
			catch(FormatException)
			{
				Console.WriteLine("Invalid Input. Please try again.");			
			}
		}

		public static void Numbers()
		{
			// even create Control Handler 
			Console.WriteLine("Enter first number: ");
			x = Convert.ToDouble(Console.ReadLine());
			
			Console.WriteLine("Enter second number: ");
			y = Convert.ToDouble(Console.ReadLine());
			
		}
		
	}
}
