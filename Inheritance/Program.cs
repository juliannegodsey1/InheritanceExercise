using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Bird myBird = new Bird();
            myBird.Age = 10;
            myBird.IsAlive = true;
            myBird.CanFly = false;
            myBird.BeakLength = 3;
            myBird.NumberOfLegs = 2;
            myBird.LandSeaAir = "Land and Sea";
            myBird.DoesMigrate = false;
            myBird.Color = "Black and White";

            Reptile myReptile = new Reptile();
            myReptile.Age = 4;
            myReptile.IsAlive = true;
            myReptile.LandSeaAir = "Land and Sea";
            myReptile.NumberOfLegs = 4;
            myReptile.IsColdBlooded = true;
            myReptile.CanGrowTail = true;
            myReptile.IsScaly = true;
            myReptile.Habitat = "Warm environments";


            Console.WriteLine($"Here are some facts about one of our birds!:\n" +
                $"Age: {myBird.Age}\n" +
                $"Color: {myBird.Color}\n" +
                $"Length of Beak: {myBird.BeakLength} \n" +
                $"Number of Legs: {myBird.NumberOfLegs} \n" +
                $"Where you can find this bird: {myBird.LandSeaAir} \n" +
                $"Does this bird migrate? Answer: {myBird.DoesMigrate} \n" +
                $"Can this bird fly? Answer: {myBird.CanFly} \n" +
                $"Is this bird currently alive? Answer: {myBird.IsAlive}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine($"Here are some facts about one of our reptiles!:\n" +
               $"Age: {myReptile.Age}\n" +
               $"Number of Legs: {myReptile.NumberOfLegs} \n" +
               $"Type of Habitat: {myReptile.Habitat} \n" +
               $"Where you can find this reptile: {myReptile.LandSeaAir} \n" +
               $"Is this reptile currently alive? Answer: {myReptile.IsAlive} \n" +
               $"Is this reptile cold blooded? Answer: {myReptile.IsColdBlooded} \n" +
               $"Is this reptile scaly? Answer: {myReptile.IsScaly}");


            
        }
    }
}
