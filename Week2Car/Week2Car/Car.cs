//Car class.  Standard choses for a car.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Car
{
    class Car
    {

        //Declaring variables 
        const int LOWEST_YEAR_CAR = 1960;
        private string chooseCar;
        public string chosenCar = "";
        private string year;
        public string yearRange = "";
        private string standardColor;
        public string color = "";
        private string choseTires;
        public string tires = "";
        private string choseEngine;
        public string engine = "";
        public static int CarCount = 0;


        // Set color option

        public void setStandardColors(string color)
        {

            String[] colorsStandard = new String[] { "Green", "Blue", "Red", "Black", "White", "Yellow" };
            Console.WriteLine();
            Console.WriteLine("Chose a standard Color.");
            Console.WriteLine("Standard colors are: ");
            Console.WriteLine();
            for (int count = 0; count < colorsStandard.Length; count++)
            {
                Console.WriteLine(colorsStandard[count]);
            }
            Console.WriteLine();
            string answer = Console.ReadLine();


            switch (answer)
            {
                case "Green":
                    color = answer;
                    standardColor = color;
                    break;
                case "Blue":
                    color = answer;
                    standardColor = color;
                    break;
                case "Red":
                    color = answer;
                    standardColor = color;
                    break;
                case "Black":
                    color = answer;
                    standardColor = color;
                    break;
                case "White":
                    color = answer;
                    standardColor = color;
                    break;
                case "Yellow":
                    color = answer;
                    standardColor = color;
                    break;
                default:

                    Console.WriteLine("Not a correct color.");
                    break;
            }
        }







        // Get standard color method

        public string getStandardColors()
        {
            return standardColor;
        }

        // Display color chosen
        public void ColorDisplay()
        {

            Console.WriteLine("The color is: " + standardColor);

        }

        // Set car type

        public void setChooseCarType(string chosenCar)
        {

            String[] chooseCarType = new String[] { "Honda Civic", "Ford Prius", "Nissan Maxima", };
            
                Console.WriteLine("Chose a car type: ");
                Console.WriteLine();
                for (int count = 0; count < chooseCarType.Length; count++)
                 {
                     Console.WriteLine(chooseCarType[count]);

                 }
                Console.WriteLine();
                chosenCar = Console.ReadLine();
            if (chosenCar == chooseCarType[0] || (chosenCar == chooseCarType[1]) || (chosenCar == chooseCarType[2]))
            {
                chooseCar = chosenCar;
            }
           else
                {
                Console.WriteLine("Please enter the correct car.");                 
                }
            
                
     }

        
        // Get car type
        public string getCarType()
        {
            return chooseCar;
             
          
        }

        // Display car type

        public void DisplayCarChosen()
        {
            Console.WriteLine("Chosen car: " + chooseCar);

        }

        // Set year range for the model with a try and catch if the incorrect car is chosen.

        public void setYearOfModel()
        {
                Console.WriteLine();
                Console.WriteLine("Enter the year range for the model car.");
                Console.WriteLine();
                int intYear = int.Parse(Console.ReadLine());
                if (intYear < LOWEST_YEAR_CAR)
                {
                    throw new NotCorrectYearException(); //Throw the exception
                }

            year = intYear.ToString();      
         }
            

        

        // Get year range of the model car

        public string getYearOfModel()
        {
            return year;
        }

        // Display year

        public void DisplayYear()
        {

            try             //Try and catch for chosen year
            {
                Console.WriteLine("The year chosen: " + year);
            }
            catch (NotCorrectYearException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }

        // Set standard tires

        public void setStandardTires(string tires)
        {
            String[] tiresStandard = new string[4] { "GoodYear", "BFGoodWrench", "Michelin Tires", "Bridgestone" };
            Console.WriteLine();
            Console.WriteLine("Choose a standard tire: ");
            Console.WriteLine();
            for (int count = 0; count < tiresStandard.Length; count++)
            {
                Console.WriteLine(tiresStandard[count]);
            }
            Console.WriteLine();
            tires = Console.ReadLine();
            choseTires = tires;
        }

        // Get standard tires

        public string getStandardTires()
        {
            return choseTires;
        }

        // Display standard tires

        public void DisplayStandardTires()
        {
            Console.WriteLine("The standard tires chosen: " + choseTires);

        }

        // Set standard engine

        public void setStandardEngine(string engine)
        {
            String[] engineStandard = new String[] { "V6", "V8" };
            Console.WriteLine();
            Console.WriteLine("Choose a standard engine: ");
            Console.WriteLine();
            for (int count = 0; count < engineStandard.Length; count++)
            {
                Console.WriteLine(engineStandard[count]);
            }
            Console.WriteLine();
            engine = Console.ReadLine();
            choseEngine = engine;
        }

        // Get standard engine

        public string getStandardEngine()
        {
            return choseEngine;
        }

        // Display standard engine

        public void DisplayStandardEngine()
        {
            Console.WriteLine("Standard engine: " + choseEngine);

        }
    }
}