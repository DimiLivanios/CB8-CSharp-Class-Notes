using System;
namespace Classes
{
    class Exercise1
    // Refer to Car.cs for the internals of the Car class
    {
        static void Main(string[] args)
        {

            Car car1 = new Car();
            /* Note that we cannot see car1.Start1 since by default it is
             * private. However, Start() is visible within Car because we
             * assigned it the 'public' modifier.
             */
            car1.Start();
            car1.company = "Ferrari";
            Console.WriteLine(car1.company);
            car1.model = "Enzo"; // Throws error
            Console.WriteLine(car1.GetModel());
            
            //Console.ReadKey()
        }
    }
}
