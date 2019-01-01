using System;
using System.Collections.Concurrent;
using System.Runtime.Remoting.Messaging;

namespace Cesar
{
	internal class Program
	{

		public static char cipher(char ch, int key)
		{
			if (!char.IsLetter(ch))
			{
				return ch;
			}

			char d = char.IsUpper(ch) ? 'A' : 'a';
			return (char)((((ch + key) - d) % 26) + d);
		}


		public static string Encipher(string input, int key)
		{
			string output = string.Empty;

			foreach (char ch in input)
				output += cipher(ch, key);
			return output;
		}

		public static string Decipher(string input, int key)
		{
			return Encipher(input, 26 - key);
		}
		
		public static void Main(string[] args)
		{
			Console.WriteLine("Type a string to encrypt: ");
			string user_string = Console.ReadLine();
			
			Console.WriteLine("\n");
			
			Console.WriteLine("Enter your key: ");
			int key = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\n");
			
			Console.WriteLine("Encrypted Data: ");

			string cipher_text = Encipher(user_string, key);
			Console.WriteLine(cipher_text);
			Console.WriteLine("\n");
			
			Console.WriteLine("Decripted Data: ");

			string decrip = Decipher(cipher_text, key);
			Console.WriteLine(decrip);
			Console.WriteLine("\n");

			Console.ReadKey();

		}
	}
}
