using System;
using System.Linq;

namespace A4Kontrollstruktur
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			int user_input;
			Console.Write("Enter number from 1 to 7: ");
			user_input = Convert.ToInt32(Console.ReadLine());

			if (user_input > 7)
			{
				Console.WriteLine("Invalid Input!");
				Environment.Exit(1);
			}

			string[] days = {"Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sontag"}; 
			
			for (int i=0, n=0 ;i < user_input && n < days.Length; ++i, n++)
			{
				if (i == 0)
				{
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", i, days[n]);
				}
				else if (i == 1)
				{
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", i, days[n]);
				}
				else if (i == 2)
				{
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", i, days[n]);
				}
				else if (i == 3)
				{
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", i, days[n]);
				}
				else if (i == 4)
				{
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", i, days[n]);
				}
				else if (i == 5)
				{
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", i, days[n]);
				}
				else if (i == 6)
				{
					Console.WriteLine("Fur die Eingabe {0} wird der Wert {1}.", i, days[n]);
				}
				else
				{
					Console.WriteLine("Invalid Input.");
				}


			}

		}
	}
}
