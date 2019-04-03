using System;

namespace DObjectCalculator

{
    /*
     * This interface is used in Sphere, RectangularPrism and Cone classes
     */
    public interface ICalculations
    {
        double CalculateSurfaceArea(); //Used to calculate Surface Area of a 3D object
        double CalculateVolume();      //Used to calculate Volume of a 3D object
    }
}
