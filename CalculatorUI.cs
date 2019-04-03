using System;
namespace DObjectCalculator

{
    public class CalculatorUI
    {
        /*
         *  Console interface for selecting an object to calculate
         *  Also has a statement to not allow illegal input
         */        
        private string PrintMainUI()
        {
            Console.WriteLine("Select an option below - ");
            Console.WriteLine("\nSurface area of: ");
            Console.WriteLine("\t1. Sphere");
            Console.WriteLine("\t2. Rectangular Prism");
            Console.WriteLine("\t3. Cone");
            Console.WriteLine("\nVolume of: ");
            Console.WriteLine("\t4. Sphere");
            Console.WriteLine("\t5. Rectangular Prism");
            Console.WriteLine("\t6. Cone");
            Console.WriteLine("\nEnter selection: ");

            string input = Console.ReadLine();

            if (input != "1" || input != "2" || input != "3" || input != "4" || input != "5" || input != "6")   //If illegal statement, return invalid
            {
                Console.WriteLine("Invalid Option!!!");
            }

            return input;   //Returns user selction for use in SelectNewObject Method
        }

        /*
         *  Creates a new object based on object selected and input from PrintMainUI
         *  Invokes CallOutput to continue user specified calculation        
         */
        private void SelectNewObject(string input)
        {
            if (input == "1" || input == "4")   //If 1 or 4, invoke a new sphere object
            {
                CalculatorUI new_sphere = Sphere.CreateNewSphere();   //Create new object
                CallOutput(input, new_sphere);  //Return input and object in CallOutput function for calculation
            }
            else if (input == "2" || input == "5")  //If 2 or 5, invokes a new rectangular prism object
            {
                CalculatorUI new_rect_prism = RectangularPrism.CreateNewRectangularPrism();
                CallOutput(input, new_rect_prism);
            }
            else if (input == "3" || input == "6")  //If 3 or 6, invoke a new cone object
            {
                CalculatorUI new_cone = Cone.CreateNewCone();
                CallOutput(input, new_cone);
            }
        }

        /*
         *  Determines what calculation is being invoked (surface area or volume, does not matter what object type)
         *  This is essentially a helper function for GetSurfaceArea or GetVolume
         *  Does not do calculation of its own; calls for a calculation to be made
         *  Returns requested calculation        
         */
        private void CallOutput(string input, CalculatorUI calc)
        {
            if (input == "1" || input == "2" || input == "3")
            {
                string surf_area = Convert.ToString(calc.GetSurfaceArea()); //Invokes GetSurfaceArea to calculate the surface area of object specified by user
                Console.WriteLine("Surface Area : " + surf_area);
            }
            else if(input == "4" || input == "5" || input == "6")
            {
                string volume = Convert.ToString(calc.GetVolume()); //Invokes GetVolume to calculate the volume of object specified by user
                Console.WriteLine("Volume : " + volume);
            }
        }

        /*
         *  After type of calculation is determined in CallOutput, this method calls the correct calcuation method for Surface Area
         *  Is a polymorphic method which is overrided by the shape objects method (sphere, cone, rectngular prism)
         */        
        public virtual double GetSurfaceArea()
        {
            Console.Clear();
            Console.WriteLine("The surface area of the 3D object - ");
            return 0;
        }

        /*
         *  After type of calculation is determined in CallOutput, this method calls the correct calculation method for volume
         *  Is a polymorphic method which is overrided by the shape objects method (sphere, cone, rectangular prism)
         */
        public virtual double GetVolume()
        {
            Console.Clear();
            Console.WriteLine("The volume of the 3D object - ");
            return 0;
        }

        /*
         *  Stores user input to be used in methods that require the users' request
         *  SelectNewObject runs with the user determined request
         *  This method put all of the pieces together and runs one loop of the program        
         */        
        public void PrintUI()
        {
            string input = PrintMainUI();   //user input stored
            SelectNewObject(input);
        }

    }
}
