//Custom class inherits Car class.  Custom includes extra choices for a car.  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Car
{
    class CustomCar : Car
    {
        //Declaring variables
        private string customEngine;
        private string customTires;
        private string customColors;
        public string extraColors = "";
        public string extraTires = "";
        public string newEngine = "";


        //Set custom colors

        public void setCustomColors(string extraColors)
        {
            String[] colorsCustom = new String[] {"Purple", "Cream", "Tan", "Violet", "Pink", "Chestnut Brown" };
            Console.WriteLine();
            Console.WriteLine("Extra colors include: ");
            for (int count = 0; count < colorsCustom.Length; count ++)
            {
                Console.WriteLine(colorsCustom[count]);    
            }
            Console.WriteLine();
            extraColors = Console.ReadLine();
            customColors = extraColors;
        }

        //Get custom colors

        public string getCustomColors()
        {
            return customColors;
        }

        //Display custom colors

        public void DisplayCustomColors()
        {
            Console.WriteLine("Custom color: " + customColors);
        }
              
        //Set custom engine 
            
        public void setCustomEngine(string newEngine)
        {
            String[] engineCustom = new string[] {"V6 350 automatic", "V6 450 automatic", "V6 350 manual", "V8 455 automatic" };
            Console.WriteLine();
            Console.WriteLine(" Custom engine: ");
            for (int count = 0; count < engineCustom.Length; count++)
            {
                Console.WriteLine(engineCustom[count]);
            }
            Console.WriteLine();
            newEngine = Console.ReadLine();
            customEngine = newEngine;
        }

        //Get custom engine

        public string getCustomEngine()
        {
            return customEngine;
        }

        //Display custom engine

        public void DisplayCustomEngine()
        {
            Console.WriteLine("Custom engine: " + customEngine);
        }

        //Set custom tires

        public void setCustomTires(string extraTires)
        {
            String[] tiresCustom = new String[] {"GoodYear All-season", "BFGoodwrench Extra-tread", "Michelin Snow tires", "Bridgestone 4X4" };
            Console.WriteLine();
            Console.WriteLine("Custom tires: ");
            for (int count = 0; count < tiresCustom.Length; count++)
            {
                Console.WriteLine(tiresCustom[count]);

            }
            Console.WriteLine();
            extraTires = Console.ReadLine();
            customTires = extraTires;
        }

        //Get custom tires

        public string getCustomTires()
        {
            return customTires;
        }

        //Display customer tires

        public void DisplayCustomTires()
        {
            Console.WriteLine("Custom tires: " + customTires);
        }

    }
         
}
