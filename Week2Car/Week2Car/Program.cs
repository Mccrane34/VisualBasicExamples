// Title: Week two individual assignment.  Class hierarchy
// Univerity of Phoenix 2016
// By: Michael Crane




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Car
{

    // Main program.  Set, get and display methods are called.  Switch statements are used to specify standard or custom specifications.
    // Year and model or car is chosen.
    class Program
    {
        static void Main(string[] args)
        {
            Car carobject = new Car();
            CustomCar customObject = new CustomCar();
            carobject.setChooseCarType(carobject.chosenCar);
            carobject.getCarType();
            carobject.DisplayCarChosen();
            carobject.setYearOfModel();
            carobject.getYearOfModel();
            carobject.DisplayYear();
            Console.WriteLine();
            Console.WriteLine("Do you want to chose standard or custom colors?");
            Console.WriteLine("Enter S for standard and C for custom.");
            Console.WriteLine();
            string answerColors = Console.ReadLine();
            switch (answerColors)
            {
                case "S":
                    carobject.setStandardColors(carobject.color);
                    carobject.getStandardColors();
                    carobject.ColorDisplay();
                    break;
                case "C":
                    customObject.setCustomColors(customObject.extraColors);
                    customObject.getCustomColors();
                    customObject.DisplayCustomColors();
                    break;
                default:
                    Console.WriteLine("Please enter the correct letter.");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Do you want to choose standard or custom tires?");
            Console.WriteLine("Enter S for standard and C for custom.");
            Console.WriteLine();
            string answerTires = Console.ReadLine();
            switch(answerTires)
            {
                case "S":
                    carobject.setStandardTires(carobject.tires);
                    carobject.getStandardTires();
                    carobject.DisplayStandardTires();
                    break;
                case "C":
                    customObject.setCustomTires(customObject.extraTires);
                    customObject.getCustomTires();
                    customObject.DisplayCustomTires();
                    break;
                default:
                    Console.WriteLine("Please enter the correct letter.");
                    break;

            }
            Console.WriteLine();
            Console.WriteLine("Do you want to choose standard or customer engines?");
            Console.WriteLine("Enter S for standard and C for custom.");
            Console.WriteLine();
            string answerEngine = Console.ReadLine();
            switch (answerEngine)
            {
                case "S":
                    carobject.setStandardEngine(carobject.engine);
                    carobject.getStandardEngine();
                    carobject.DisplayStandardEngine();
                    break;
                case "C":
                    customObject.setCustomEngine(customObject.newEngine);
                    customObject.getCustomEngine();
                    customObject.DisplayCustomEngine();
                    break;
                default:
                    Console.WriteLine("Please enter the correct letter.");
                    break;



            }
                 

        }
    }
}






