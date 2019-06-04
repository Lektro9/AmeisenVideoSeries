/*
 * Created by SharpDevelop.
 * User: TheBestNew01
 * Date: 02-Jun-19
 * Time: 5:35 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ameise000001
{
	class Program
	{
		public static void Main(string[] args)
		{

			AmeiseLauf(20);
			
			
			Console.ReadKey(true);
		}
		
		public static void Add(int ersteZahl, int zweiteZahl)
		{
			Console.WriteLine(ersteZahl + zweiteZahl);
		}
		
		public static void AmeiseLauf(int laufweite)
		{
			int x = 10;
			int y = 10;
			
			for (int i = 0; i <= laufweite; i++) 
			{
				Console.SetCursorPosition(x+i, y);
				Console.WriteLine("A");
				System.Threading.Thread.Sleep(500);
				Console.SetCursorPosition(x+i, y);
				Console.WriteLine(" ");
			}
		}
	}
}
