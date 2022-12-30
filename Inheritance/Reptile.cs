using System;
using System.Xml.Linq;

namespace Inheritance
{
	public class Reptile : Animal
	{
        //Constructor
        public Reptile()
		{
		}

        //Reptile Properties/Members
		public bool IsColdBlooded { get; set; }
		public bool Scaly { get; set; }
		public bool IsPoisonous { get; set; }
		public bool HasLegs { get; set; }


        //Method to mention if the reptile is cold-blooded or not in present or past tense based on if the reptile is alive or not.
        public void ColdorWarm()
		{
            if (IsAlive == true)
            {
                if (IsColdBlooded == true)
                    {
                        Console.WriteLine($"It is cold-blooded.");
                    }
                else
                    {
                        Console.WriteLine($"It is warm-blooded.");
                    }
            }
            else
            {
                if (IsColdBlooded == true)
                {
                    Console.WriteLine($"It was cold-blooded.");
                }
                else
                {
                    Console.WriteLine($"It was warm-blooded.");
                }
            }
           
        }

        //Method to mention if the reptile is scaly or not in present or past tense based on if the reptile is alive or not.
        public void IsScaly()
		{
            if (IsAlive == true)
            {
                if (Scaly == true)
                {
                    Console.WriteLine($"It definitely has scales!");
                }
                else
                {
                    Console.WriteLine($"No scales for this one.");
                }
            }
            else
            {
                if (Scaly == true)
                {
                    Console.WriteLine($"It definitely had scales!");
                }
                else
                {
                    Console.WriteLine($"No scales for this one.");
                }
            }

        }

        //Method to mention if the reptile is poisonous or not in present or past tense based on if the reptile is alive or not.
        public void PoisonOrNot()
        {
            if (IsPoisonous == true)
            {
                Console.WriteLine($"Be cautious around this one because it is poisonous!"); 
            }
            else
            {
                Console.WriteLine($"Being nonpoisonous makes it safe to an extent.");
            }
        }

        //Method to mention if the reptile has legs or not in present or past tense based on if the reptile is alive or not.
        public void LegsOrNot()
        {

            if (IsAlive == true)
            {
                if (HasLegs == true)
                {
                    Console.WriteLine($"Watch out because it might chase you."); 
                }
                else
                {
                    Console.WriteLine($"No running for this one though because it has no legs.");
                }
            }
            else
            {
                if (HasLegs == true)
                {
                    Console.WriteLine($"When it was alive, you would've had to watch out because it might've chased you.");
                }
                else
                {
                    Console.WriteLine($"No running for this one though because it had no legs.");
                }
            }

        }

	}
}

