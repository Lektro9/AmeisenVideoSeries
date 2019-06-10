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
	class BildschirmObjekt
	{
		public int posX;
		public int posY;
		
		public void Init(int posX, int posY) 
		{
			this.posX = posX;
			this.posY = posY;
		}
	}
	class Ant : BildschirmObjekt
	{
		public int energie = 0;
		
		public void CheckIfFoodIsTouched(Food[] Essen)
		{
			for (int i = 0; i < Essen.Length; i++) 
			{
				if (Essen[i].posX == this.posX) 
				{
					if (Essen[i].posY == this.posY) 
					{
						energie++;
					}
				}
			}
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
	
	class Food : BildschirmObjekt
	{	
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
			int Schritte = 40;
			
			Ant[] Ameisen = new Ant[5];
			Food[] Essen = new Food[3];
			
			// Initialisierung
			for (int i = 0; i < Ameisen.Length; i++) 
			{
				Ameisen[i] = new Ant();
				Ameisen[i].Init(i+5, i+2);
			}
			
			
			for (int i = 0; i < Essen.Length; i++) 
			{
				Essen[i] = new Food();
				Essen[i].Init(30, 2+i);
			}
			
			
			
			
			
			// HauptLoop
			for (int i = 0; i < Schritte; i++)
			{
				for (int j = 0; j < Ameisen.Length; j++) 
				{
					Ameisen[j].Move();
					Ameisen[j].CheckIfFoodIsTouched(Essen);
				}
				
				for (int j = 0; j < Essen.Length; j++) 
				{
					Essen[j].Show();
				}
				System.Threading.Thread.Sleep(100);
				
				Console.SetCursorPosition(1, 30);
				Console.WriteLine("Ameise01 hat " + Ameisen[0].energie + " energie.");
			}
			Console.ReadKey(true);
		}
	}
}