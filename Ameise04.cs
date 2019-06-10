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
			Console.SetCursorPosition(posX, posY);
			Console.WriteLine(" ");
			posX++;
			//posY++;
			//Console.WriteLine(posX + " " + posY);
			
			Console.SetCursorPosition(posX, posY);
			Console.WriteLine("A");
		}
		
	}
	
	class Food
	{
		public int posX = 20;
		public int posY = 12;
		
		public void Show() 
		{
			Console.SetCursorPosition(posX, posY);
			Console.WriteLine("F");
		}
	}
	
	class Program
	{
		public static void Main(string[] args)
		{

			Ant Ameise01 = new Ant();
			Ant Ameise02 = new Ant();
			
			Food Essen01 = new Food();
			
			// Initialisierung
			Ameise01.Init(10, 12);
			Ameise02.Init(11, 17);
			
			
			while (true) 
			{
				Ameise01.Move();
				Ameise02.Move();
				Essen01.Show();
				System.Threading.Thread.Sleep(100);
			}
			
			
			
			
			
			
			
			Console.ReadKey(true);
		}
	}
}