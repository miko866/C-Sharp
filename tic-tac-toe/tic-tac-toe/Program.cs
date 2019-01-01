using System;
using System.Security.Policy;

namespace tic_tac_toe
{
	internal class MainClass
	{
		public static void Main(string[] args)
		{
			char player = 'X';
			char[,] board = new char[3, 3];
			
			Initialize(board);
			
			// Game
			while (true)
			{
				Console.Clear();
				Print(board);
				
				Console.Write("Please enter row: ");
				int row = Convert.ToInt32(Console.ReadLine());
				Console.Write("Please enter column: ");
				int col = Convert.ToInt32(Console.ReadLine());
	
				board[row, col] = player;
				
				// Check if we won
				if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
				{
					Console.WriteLine(player + " has won the game!");
					break;
				}
				
				player = ChangeTurn(player);

			}	
			
			// Celebration for Winner
			Console.Clear();
			Print(board);

		}

		static char ChangeTurn(char currentPlayer)
		{
			if (currentPlayer == 'X')
			{
				return 'O';
			}
			else
			{
				return 'X';
			}
		}
		
		
		

		static void Initialize(char[,] board)
		{
			for (int row = 0; row < 3; row++)
			{
				for (int col = 0; col < 3; col++)
				{
					board[row, col] = ' ';
				}
			}
		}

		static void Print(char[,] board)
		{
			Console.WriteLine(" | 0 | 1 | 2 |");
			for (int row = 0; row < 3; row++)
			{
				Console.Write(row + "| ");
				for (int col = 0; col < 3; col++)
				{
					Console.Write(board[row, col]);
					Console.Write(" | ");
				}
				Console.WriteLine();
			}
		}
	}
}
