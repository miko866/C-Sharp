using System;

namespace A5Kontrollstruktur
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			int user_input;
			Console.Write("Enter number from 0 to 6: ");
			user_input = Convert.ToInt32(Console.ReadLine());

			if (user_input > 6)
			{
				Console.WriteLine("Invalid Input!");
				Environment.Exit(1);
			}

			
			switch (user_input)
			{
				case 0:
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", user_input, "Montag");
					break;
				case 1:
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", user_input, "Montag & Dienstag");
					break;
				case 2:
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", user_input, "Montag & Dienstag & mittwoch");
					break;
				case 3:
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", user_input, "Montag & Dienstag & Mittwoch & Donnerstag");
					break;
				case 4:
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", user_input, "Montag & Dienstag & Mittwoch & Donnerstag & Freitag");
					break;
				case 5:
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", user_input, "Montag & Dienstag & Mittwoch & Donnerstag & Freitag & Samstag");
					break;
				case 6:
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", user_input, "Montag & Dienstag & Mittwoch & Donnerstag & Freitag & Samstag & Sontag");
					break;
				default:
					Console.WriteLine("Invalid Input.");
					break;
			}
			

		}
	}
}
