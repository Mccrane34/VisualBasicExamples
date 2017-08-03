using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollTwoDice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            for (int counter = 0; counter <101; counter++)
            {
                GenerateNumber(counter);
                Console.WriteLine("Press enter to roll again.");
                Console.ReadLine();
            }
          
        }
        static void GenerateNumber(int counter)
        {
            int dice1;
            int dice2;
            
            Random rndNumber = new Random();
            dice1 = rndNumber.Next(6);
            dice2 = rndNumber.Next(6);
            if(dice1.Equals(dice2))
            {
                Console.WriteLine("Dice one: " + dice1);
                Console.WriteLine("Dice two: " + dice2);
                Console.WriteLine("Roll sequence: " + counter);
            }
            else
            {
                Console.WriteLine("Dice one: " + dice1);
                Console.WriteLine("Dice two: " + dice2);
            }
            
        }
        
    }
}
