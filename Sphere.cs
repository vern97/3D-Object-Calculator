using System;
namespace DObjectCalculator
{
    public class Sphere : CalculatorUI , ICalculations
    {
        //Private variables for radius of a Sphere object
        private double s_radius;

        public Sphere(double radius)
        {
            s_radius = radius;
        }

        /*  
         *  Creates a Sphere object based on user input
         *  Also clears console to tidy up    
         */
        static public Sphere CreateNewSphere()
        {
            Console.Clear();
            Console.WriteLine("Enter Radius: ");
            double radius = Convert.ToInt32(Console.ReadLine());    //User input for radius
            return new Sphere(radius);
        }

        /*
         *  Uses CalculateSurfaceArea declared in interface to return Surface Area of Sphere
         *  Uses HelperCalculate() method to derive Surface Area formula
         */
        public double CalculateSurfaceArea()
        {
            return (4) * HelperCalculate();
        }

        /*
         *  Uses CalculateVolume declared in interface to return Volume of Sphere
         *  Uses HelperCalculate() method to derive Surface Area formula
         */
        public double CalculateVolume()
        {
            return (4 / 3) * HelperCalculate();
        }

        /*
         *  A helper function to be implemented in SurfaceArea and Volume methods
         *  Calculates slant height        
         */
        private double HelperCalculate()
        {
            return ((Math.PI) * (Math.Pow(s_radius, 2)));   //Product of pi and radius to power of 2 for surface area and volume
        }

        /*
         *  Uses polymorhpism to override GetSurfaceArea() method in CalculatorUI class
         *  Returns Surface Area as calculated by method CalculateSurfaceArea()        
         */
        public override double GetSurfaceArea()
        {
            Console.Clear();
            Console.WriteLine("The surface area of the 3D Sphere - ");
            return CalculateSurfaceArea();
        }

        /*  
         *  Uses polymorphism to override GetVolume() method in CalculatorUI class
         *  Returns Surface Area as calculated by method CalculateVolume()
         */
        public override double GetVolume()
        {
            Console.Clear();
            Console.WriteLine("The volume of the 3D Sphere - ");
            return CalculateVolume();
        }

        /*
         *  Returns radius of current object
         *  Not used in any implmentation; used if I ever want to extend this program as a future project
         */
        public double GetRadius()
        {
            return s_radius;
        }
    }
}
