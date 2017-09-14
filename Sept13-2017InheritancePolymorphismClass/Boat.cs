using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept13_2017InheritancePolymorphismClass
{
    class Boat : Vehicle // here-- : Vehicle is what inherits from Vehicle
        //everything in that class is here too (unless private)
    {
        //fields: 

        private double waterDrag;

        //constructors:

        public Boat(int seats, int carryingCapacity, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;

        }

        //methods:
        //boats move different from other vehicles
        //so we will OVERRIDE the Vehicle Move method.
        //remember: override PERMITS overriding, doesn't compel it

        public override void Move()
        {
            //base.Move(); //this line will let you use the Base (Vehicle) Move method

            distanceTraveled += movementSpeed * waterDrag;
        }
    }
}
