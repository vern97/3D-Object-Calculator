using System;
namespace DObjectCalculator

{
    public class Cone : CalculatorUI , ICalculations
    {
        //Private variables for radius and height of Cone
        private double c_radius, c_height;

        public Cone(double radius, double height)
        {
            c_radius = radius;
            c_height = height;
        }

        /*  
         *  Creates a new cone object based on user input
         *  Also clears console to tidy up    
         */
        static public Cone CreateNewCone()
        {
            Console.Clear();
            Console.WriteLine("Enter Radius: ");
            double radius = Convert.ToInt32(Console.ReadLine());    //Convert user input radius to double
            Console.WriteLine("Enter Height: ");
            double height = Convert.ToInt32(Console.ReadLine());    //Convert user input height to double
            return new Cone(radius, height);    //Returns new Cone object with specified radius and height
        }

        /*
         *  Uses CalculateSurfaceArea laid out in interface to return Surface Area of Cone
         *  Method broke down into pieces to be more easily readable        
         */
        public double CalculateSurfaceArea()
        {
            double sqrt_radius, sqrt_height, slant_height, area_of_cone, area_of_base;
            sqrt_radius = (Math.Pow(c_radius, 2));
            sqrt_height = (Math.Pow(c_height, 2));
            slant_height = (Math.Sqrt(sqrt_radius + sqrt_height));
            area_of_cone = ((Math.PI) * (c_radius) * (slant_height));
            area_of_base = ((Math.PI) * (Math.Pow(c_radius, 2)));
            return (area_of_cone + area_of_base);   //Returns surface area (area of cone multiplied by area of base)
        }

        /*
         *  Uses CalculateVolume declared in interface to return Volume of Cone
         */
        public double CalculateVolume()
        {
            double radius_sqr = (Math.Pow(c_radius, 2));
            double cone_base = (Math.PI * radius_sqr);
            return ((.33333) * cone_base * (c_height)); //Returns volume
        }

        /*
         *  Uses polymorhpism to override GetSurfaceArea() method in CalculatorUI class
         *  Returns Surface Area as calculated by method CalculateSurfaceArea()        
         */
        public override double GetSurfaceArea()
        {
            Console.Clear();
            Console.WriteLine("The surface area of the 3D Cone - ");
            return CalculateSurfaceArea();
        }

        /*  
         *  Uses polymorphism to override GetVolume() method in CalculatorUI class
         *  Returns Surface Area as calculated by method CalculateVolume()
         */        
        public override double GetVolume()
        {
            Console.Clear();
            Console.WriteLine("The volume of the 3D Cone - ");
            return CalculateVolume();
        }

        /*
         *  Returns radius of current object
         *  Not used in any implmentation; used if I ever want to extend this program as a future project
         */        
        public double GetRadius()
        {
            return c_radius;
        }

        /*
         *  Returns height of current object
         *  Not used in any implmentation; used if I ever want to extend this program as a future project
         */
        public double GetHeight()
        {
            return c_height;
        }
    }
}
