using System;
namespace DObjectCalculator

{
    public class RectangularPrism : CalculatorUI , ICalculations
    {
        //Private variables for length, width and height of a Rectangular Prism Object
        private double rp_length, rp_width, rp_height;

        public RectangularPrism(double length, double width, double height)
        {
            rp_length = length;
            rp_width = width;
            rp_height = height;
        }

        /*  
         *  Creates a new rectangular prism object based on user input
         *  Also clears console to tidy up    
         */
        static public RectangularPrism CreateNewRectangularPrism()
        {
            Console.Clear();
            Console.WriteLine("Enter Length: ");
            double length = Convert.ToInt32(Console.ReadLine());    //User input length
            Console.WriteLine("Enter Width: ");
            double width = Convert.ToInt32(Console.ReadLine());     //User input width
            Console.WriteLine("Enter Height: ");   
            double height = Convert.ToInt32(Console.ReadLine());    //User input height
            return new RectangularPrism(length, width, height); //Declares object with user input
        }

        /*
         *  Uses CalculateSurfaceArea declared in interface to return Surface Area of Cone
         *  Method broke down into pieces to be more easily readable        
         */
        public double CalculateSurfaceArea()
        {
            double length_times_width, length_times_height, width_times_height;
            length_times_width = (rp_length * rp_width);    //Product of length and width
            length_times_height = (rp_length * rp_height);  //Product of length and height
            width_times_height = (rp_width * rp_height);    //Product of weith and height
            return (2 * ((length_times_width) + (length_times_height) + (width_times_height))); //Formula for Surface area of rectangular prism
        }

        /*
         *  Uses CalculateVolume declared in interface to return Volume of Cone
         */
        public double CalculateVolume()
        {
            return ((rp_length) * (rp_width) * (rp_height));    //Formula of volume of rectangular prism
        }

        /*
         *  Uses polymorhpism to override GetSurfaceArea() method in CalculatorUI class
         *  Returns Surface Area as calculated by method CalculateSurfaceArea()        
         */
        public override double GetSurfaceArea()
        {
            Console.Clear();
            Console.WriteLine("The surface area of the 3D Rectangular Prism - ");
            return CalculateSurfaceArea();
        }

        /*  
         *  Uses polymorphism to override GeTVolume() method in CalculatorUI class
         *  Returns Surface Area as calculated by method CalculateVolume()
         */
        public override double GetVolume()
        {
            Console.Clear();
            Console.WriteLine("The volume of the 3D Rectangular Prism - ");
            return CalculateVolume();
        }

        /*
         *  Returns length of current object
         *  Not used in any implmentation; used if I ever want to extend this program as a future project
         */
        public double GetLength()
        {
            return rp_length;
        }

        /*
         *  Returns width of current object
         *  Not used in any implmentation; used if I ever want to extend this program as a future project
         */
        public double GetWidth()
        {
            return rp_width;
        }

        /*
         *  Returns height of current object
         *  Not used in any implmentation; used if I ever want to extend this program as a future project
         */
        public double GetHeight()
        {
            return rp_height;
        }
    }
}
