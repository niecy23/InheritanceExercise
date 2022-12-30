using System;
namespace Inheritance
{
    public class Animal
	{
		//Constructor
		public Animal()
		{
		}

		//Animal Properties/Members
		public bool IsAlive { get; set; }
		public int Age { get; set; }
		public int LegCount { get; set; }
		public string LandSeaAir { get; set; }

		//Method to determine if the animal is alive or not. 
		public void AliveStatus()
		{
			if (IsAlive == false)
			{
				Console.WriteLine("Rest in Peace."); 
			}
			else
			{
				Console.WriteLine($"Still lively and playing."); 
			}
		}

		//Method to provide basic information about the animal using present or past tense based if the animal is alive or not.
		public void BasicInfo()
		{
			
			if (IsAlive == true)
            {
                if (Age == 1)
                {
                    Console.WriteLine($"This animal is currently {Age} year old.");
                }
                else
                {
                    Console.WriteLine($"This animal is currently {Age} years old.");
                }

                if (LegCount == 1)
				{
					Console.WriteLine($"It has {LegCount} leg, and {LandSeaAir} is where you will find it.");
				}
				else
				{
					Console.WriteLine($"It has {LegCount} legs, and {LandSeaAir} is where you will find it.");
				}

			}
			else
			{
                if (Age == 1)
                {
                    Console.WriteLine($"This animal was {Age} year old.");
                }
                else
                {
                    Console.WriteLine($"This animal was {Age} years old.");
                }

                if (LegCount == 1)
				{
					Console.WriteLine($"It had {LegCount} leg, and {LandSeaAir} is where you would have found it.");
				}
				else
				{
					Console.WriteLine($"It had {LegCount} legs, and {LandSeaAir} is where you would have found it.");
				}
			}
		}

	}
}

