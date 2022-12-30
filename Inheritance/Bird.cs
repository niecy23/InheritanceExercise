using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		//Constructor
		public Bird()
		{
		}

		//Bird Properties/Members
		public bool CanFly { get; set; }
		public string WingColor { get; set; }
		public bool DoMigrate { get; set; }
		public double BeakLength { get; set; }


        //Method to mention if the bird can fly or not in present or past tense based on if the bird is alive or not.
        public void FlightStatus()
		{
			if (IsAlive == true)
			{
				if (CanFly == true)
				{
					Console.WriteLine($"It can fly!");
				}
				else
				
					Console.WriteLine($"Unfortunately, it cannot fly.");
				}
			else
			{
				if (CanFly == true)
				{
					Console.WriteLine($"It could fly!");
				}
				else
				{
					Console.WriteLine($"Unfortunately, it could not fly.");
				}
			}

		}

        //Method to mention if the bird migrates in present or past tense based on if the bird is alive or not.
        public void Migration()
		{
			if (IsAlive == true)
			{
				if (DoMigrate == true)
				{
					Console.WriteLine($"It migrates.");
				}
				else
				{
					Console.WriteLine($"It has no need to migrate.");
				}
			}
			else
			{
                if (DoMigrate == true)
                {
                    Console.WriteLine($"It migrated.");
                }
                else
                {
                    Console.WriteLine($"It did not have a need to migrate.");
                }
            }
		
        }

        //Method to mention the beak length in present or past tense based on if the bird is alive or not.
        public void BeakDimensions()
		{
			if (IsAlive == true)
			{
				if (BeakLength == 1)
				{
					Console.WriteLine($"It also has a beak that is {BeakLength} inch long.");
				}
				else
				{
					Console.WriteLine($"It also has a beak that is {BeakLength} inches long.");
				}
			}
			else
			{
				if (BeakLength == 1)
				{
					Console.WriteLine($"It also had a beak that was {BeakLength} inch long.");
				}
				else
				{
					Console.WriteLine($"It also had a beak that was {BeakLength} inches long.");
				}
			}
		}

		//Method to mention wing color in present or past tense based on if the bird is alive or not.
		public void Wings()
		{
			if (IsAlive == true)
			{
				Console.WriteLine($"It has stunning {WingColor} wings.");
			}
			else
			{
                Console.WriteLine($"It had stunning {WingColor} wings.");
            }
		
        }
 
	}
}

