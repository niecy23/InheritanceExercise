using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // DONE Be sure to follow best practice when creating your classes

            // Create a class Animal - DONE
            // give this class 4 members that all Animals have in common - DONE


            // Create a class Bird - DONE
            // give this class 4 members that are specific to Bird - DONE
            // Set this class to inherit from your Animal Class - DONE

            // Create a class Reptile - DONE
            // give this class 4 members that are specific to Reptile - DONE
            // Set this class to inherit from your Animal Class - DONE




            /*Create an object of your Bird class - DONE
             *  give values to your members using the object of your Bird class - DONE
             *  
             * Creatively display the class member values  - DONE
             */

            /*Create an object of your Reptile class - DONE
             *  give values to your members using the object of your Reptile class - DONE
             *  
             *  	
             * Creatively display the class member values  - DONE
             */




            //Creating an instance of the Bird class and adding values.
            var Penguin = new Bird()
            {
                IsAlive = true,
                Age = 7,
                LegCount = 2,
                LandSeaAir = "land or sea",

                CanFly = false,
                WingColor = "black",
                DoMigrate = false,
                BeakLength = 3
            };

            //Giving the bird a name.
            var birdName = "Pedro the Penguin";

            //Providing a description of the bird using the created properties/methods.
            Console.WriteLine($"Let me introduce you to {birdName}.");

            Penguin.AliveStatus();

            Penguin.BasicInfo();

            Penguin.FlightStatus();

            Penguin.Wings();

            Penguin.Migration();

            Penguin.BeakDimensions();

            Console.WriteLine("Such a beauty!"); 

            //Creating an instance of the Reptile class and adding values.
            var Snake = new Reptile()
            {
                IsAlive = true,
                Age = 10,
                LegCount = 0,
                LandSeaAir = "land or sea",

                IsColdBlooded = true,
                Scaly = true,
                IsPoisonous = true,
                HasLegs = false
            };

            //Giving the reptile a name.
            var reptileName = "Sally the Snake";

            //Providing a description of the reptile using the created properties/methods.
            Console.WriteLine($"While we are at it, I will tell you about {reptileName} as well.");

            Snake.AliveStatus();

            Snake.BasicInfo();

            Snake.ColdorWarm();

            Snake.IsScaly();

            Snake.PoisonOrNot();

            Snake.LegsOrNot();

            Console.WriteLine($"I hope you enjoyed learning about these animals."); 
        }
    }
}
