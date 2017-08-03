using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 0; counter <101; counter++)
            {
                int dice1;
                int dice2;
                Random rnd = new Random();
                dice1 = rnd.Next(6);
                dice2 = rnd.Next(6);
                DisplayDice(dice1, dice2, counter);
                Console.WriteLine();
            }
            
             

        }
        static void DisplayDice(int roll1, int roll2, int counter)
        {
            

            if (roll1.Equals(roll2))
            {
                

                Console.WriteLine("Dice one: " + roll1);
                Console.WriteLine("Dice two: " + roll2);
                Console.WriteLine("Dice sequence: " + counter);
                               
            }
            else
            {
                Console.WriteLine("Dice one: " + roll1);
                Console.WriteLine("Dice two: " + roll2);
            }

           
        }

    }

}
