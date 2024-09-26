using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

namespace week5b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string heroFirstName = "Gavin";
            string heroLastName = "Webster";
            string heroFullName;
            string villianTitle = "Lord of the dangerous tool shed";
            string minionTitle = "his sons";
            string villianName;
            string minion1Name;
            string minion2Name;
            int heroHealth = 100;
            int heroStength = 50;
            int bossHealth = 100;
            int bossStrength = 25;
            int minion1Health = 50;
            int minion2Health = 50;
            int minionStrength = 5;




            //code
            heroFullName = heroFirstName + " " + heroLastName;
          




            Console.WriteLine("Behold the legendary hero of programming, whose name is: "+ heroFullName);
            villianName = "Bob";
            minion1Name = "Jimmy";
            minion2Name = "Joe";
            Console.WriteLine(heroFullName + " 's rival is " + villianName + " the " + villianTitle);

            //Minions
            Console.WriteLine("The villian has two minions called: " + minionTitle+" "+ minion1Name + " and "+ minion2Name);

            //Fight!!!!
            Console.WriteLine("The fighters enter the areana");
            Console.WriteLine("Hero's health " + heroHealth);
            Console.WriteLine("Boss's health " + bossHealth);
            Console.WriteLine("Minion 1's health " + minion1Health);
            Console.WriteLine("Minion 2's health "+minion2Health);

            //Time to fight


            //Baddies attack our hero first
            //Boss goes first 
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage!");

            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Minions attack 
            Console.WriteLine("the evil minions attack");
            Console.WriteLine(minion1Name + " deals " + minionStrength + " damage ");

            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health");
            Console.WriteLine(minion2Name + " deals " + minionStrength + " damage");

            heroHealth = heroHealth - minionStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Hero attacks
            Console.WriteLine(heroFullName + " attacks each villian for " + heroStength + " damage!");

            bossHealth -= heroStength;
            minion1Health -= heroStength;
            minion2Health -= heroStength;

            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossStrength + " health");
            Console.WriteLine(minionTitle + " " + minion1Name + " now has " + minion1Health + " health");
            Console.WriteLine(minionTitle + " " + minion2Name + " now has " + minion2Health + " health");

            Console.WriteLine(minion1Name + " and " + minion2Name + " have been defeated");

            //End of Round
            Console.WriteLine(heroFullName + " has " + heroHealth + " health");
            Console.WriteLine(heroFullName + " eats an apple to restore health!");
            heroHealth++;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health!");

            //Final Round
            Console.WriteLine("The remaining fighters continue the fight");
            Console.WriteLine("Hero's health: " + heroHealth);
            Console.WriteLine("Villian's health: " + bossHealth);
            //Boss attacks first
            Console.WriteLine(villianName + " the " + villianTitle + " attacks " + heroFullName);
            Console.WriteLine(villianName + " the " + villianTitle + " deals " + bossStrength + " damage!");

            heroHealth = heroHealth - bossStrength;
            Console.WriteLine(heroFullName + " now has " + heroHealth + " health");
            //Hero attacks
            Console.WriteLine(heroFullName + " attacks " + villianName + " the " + villianTitle + " for " + heroStength + " damage");

            bossHealth = bossHealth - heroStength;
            Console.WriteLine(villianName + " the " + villianTitle + " now has " + bossHealth + " health");

            //Results
            Console.WriteLine(heroFullName + " is victorious");
            Console.WriteLine("Wealth, glory, and staight A+'a to the winner");




        }
    }
}
