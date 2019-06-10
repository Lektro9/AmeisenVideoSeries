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
	class Ant
	{
		public string test = "Hallo ich bin da!";
		public int posX = 10;
		public int posY = 12;
	}
	class Program
	{
		public static void Main(string[] args)
		{

			Ant Ameise01 = new Ant();
			Console.WriteLine(Ameise01.test + " Und meine position lautet " + Ameise01.posX + " " + Ameise01.posY);
			Ant Ameise02 = new Ant();
			Ameise02.posX = 12;
			Ameise02.posY = 20;
			Console.WriteLine(Ameise02.test + " Und meine position lautet " + Ameise02.posX + " " + Ameise02.posY);
			Console.ReadKey(true);
		}
		
//		public static void Add(int ersteZahl, int zweiteZahl)
//		{
//			Console.WriteLine(ersteZahl + zweiteZahl);
//		}
//		
//		public static void AmeiseLauf(int laufweite)
//		{
//			int x = 10;
//			int y = 10;
//			
//			for (int i = 0; i <= laufweite; i++) 
//			{
//				Console.SetCursorPosition(x+i, y);
//				Console.WriteLine("A");
//				System.Threading.Thread.Sleep(500);
//				Console.SetCursorPosition(x+i, y);
//				Console.WriteLine(" ");
//			}
//		}
	}
}