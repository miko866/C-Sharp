using System;
using System.Data;

namespace ChristmasTree2
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			// Create user Var
			Console.WriteLine("Enter number the rows: ");
			int rows = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the size: ");
			int size = Convert.ToInt32(Console.ReadLine());
			
			// Set Variables
			int i, k, j, l;
			
			// Top
			for(i = 1; i <= 3; i++)
			{
				for(k = rows ; k >= i; k--)
				{
					Console.Write(" "); // spaces
				}
				for(j = 1; j <= 2 * i - 1; j++)
				{
					Console.Write("*"); // stars
				}
				Console.WriteLine();
			}
			
			// Middle 
			for(i = 1; i <= size ; i++)
			{
				for(k = (rows - 1); k >= i; k--)
				{
					Console.Write(" ");
				}
				for(j = 0; j <= 2 * i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			size++;
			
			// Bottom
			for(i = 1; i <= size; i++)
			{
				for(k = (rows-1); k>= i; k--)
				{
					Console.Write(" ");
				}
				for(j = 0; j <= 2 * i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			
			// Base
			for( l = 0; l < 3; l++)
			{
				for(j = rows - 1; j > 0; j--)
				{
					Console.Write(" ");
				}
				for(j = 0; j <= 2; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
