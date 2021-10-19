using System;

using Assignment3_PM.Birds;
using Assignment3_PM.Eggs;

namespace Assignment3_PM
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Bird bird;
				Console.Write("Press C for chicken or O for Ostrich: ");
				char key = Char.ToUpper(Console.ReadKey().KeyChar);
				switch (key)
				{
					case 'C':
						bird = new Chicken();
						break;
					case 'O':
						bird = new Ostrich();
						break;
					default:
						return;
				}
				Console.Write("\nHow many eggs should it lay? ");
				if (!int.TryParse(Console.ReadLine(), out int numEggs)) { return; }
				Egg[] eggs = bird.LayEggs(numEggs);
				DisplayEggs(eggs);
			}
		}

		static void DisplayEggs(Egg[] eggs)
		{
			foreach (var egg in eggs)
			{
				Console.WriteLine(egg);
			}
		}
	}
}
