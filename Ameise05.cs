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
			int Schritte = 15;
			
			Ant[] Ameisen = new Ant[5];
			Food[] Essen = new Food[3];
			
			
			for (int i = 0; i < Ameisen.Length; i++) 
			{
				Ameisen[i] = new Ant();
				Ameisen[i].Init(i+5, i+2);
			}
			
			
			for (int i = 0; i < Essen.Length; i++) 
			{
				Essen[i] = new Food();
				Essen[i].posX = i;
				Essen[i].posY = i;
			}
			
			
			
			
			// Initialisierung
			
			for (int i = 0; i < Schritte; i++)
			{
				for (int j = 0; j < Ameisen.Length; j++) 
				{
					Ameisen[j].Move();
				}
				
				for (int j = 0; j < Essen.Length; j++) 
				{
					Essen[j].Show();
				}
				System.Threading.Thread.Sleep(100);
			}
			Console.ReadKey(true);
		}
	}
}