using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept13_2017InheritancePolymorphismClass
{
    //inheritance creates a new class by using an existing class
    //"parent" class contains base methods BASE CLASS
    //"child" class contains overriding methods DERIVED CLASS
    //you can have mulitple levels of classes
    //but each level inherits only one level above
    //lame.

    class Program
    {
        static void Main(string[] args)
        {
            Boat skippy = new Boat(2, 500, "yellow", 80.00, .9); //remember, Boat constructor needs parameters

            skippy.Move();
            skippy.Move();

            Console.WriteLine($"Boat has gone {skippy.DistanceTraveled} miles or whatever."); //prints the value
            //or
            Console.WriteLine(skippy.GetDistanceTraveled()); //prints what the method returns

            Car edward = new Car(4, 18, 4, 5, 50, "copper", 60.00d);

            edward.Move();
            edward.Move();

            Console.WriteLine(edward.GetDistanceTraveled());

            Console.ReadLine();


        }
    }
}