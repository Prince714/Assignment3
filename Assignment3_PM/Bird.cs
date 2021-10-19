using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Assignment3_PM.Eggs;
namespace Assignment3_PM.Birds
{
	class Bird
	{
		public static Random Rand = new Random(1);
		public virtual Egg[] LayEggs(int numEggs)
		{
			Console.Error.WriteLine("Bird.LayEggs should not be called!");
			return new Egg[0];
		}
	}

	class Chicken : Bird
	{
		public override Egg[] LayEggs(int numEggs)
		{
		   Egg[] chicken = new Egg[numEggs];
		   for(int i=0; i<numEggs; ++i )
			{
			    var chickenegg = new Egg(Rand.Next(2, 4), Egg.Colors.brown);
				chicken[i] = chickenegg;

			}
	        return chicken;
		}
     }

	class Ostrich : Bird
	{
		public override Egg[] LayEggs(int numEggs)
		{
			Egg[] ostrich = new Egg[numEggs];
			for (int i = 0; i < numEggs; ++i)
			{
				var ostrichegg = new Egg(Rand.Next(10, 14), Egg.Colors.speckled);
				ostrich[i] = ostrichegg;

			}
			return ostrich;
		}
	}
}
