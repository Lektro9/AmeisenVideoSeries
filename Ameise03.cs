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
		public string test;
		public int posX;
		public int posY;
		
		public void Init(int posX, int posY) 
		{
			this.posX = posX;
			this.posY = posY;
			test = "Ich bin am Leben!";
			//Console.WriteLine(test + " und befinde mich an der Position "+ posX + posY);
		}
		
		public void Move() 
		{
			posX = posX + 1;
			posY++;
			//Console.WriteLine(posX + " " + posY);
			
			for (int i = 0; i <= 20; i++) 
			{
				Console.SetCursorPosition(posX+i, posY);
				Console.WriteLine("A");
				System.Threading.Thread.Sleep(500);
				Console.SetCursorPosition(posX+i, posY);
				Console.WriteLine(" ");
			}
		}
		
	}
	class Program
	{
		public static void Main(string[] args)
		{

			Ant Ameise01 = new Ant();
			Ant Ameise02 = new Ant();
			Ameise01.Init(10, 12);
			Ameise01.Move();
			Ameise02.Init(11, 13);
			Ameise02.Move();
			Console.ReadKey(true);
		}
	}
}