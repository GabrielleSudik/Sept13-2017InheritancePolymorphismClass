using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept13_2017InheritancePolymorphismClass
{
    class Car : Vehicle
    {

        //fields

        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        //properties

        public int NumberOfWheels
        {
            get { return this.numberOfWheels; }
        }

        //constructor

        public Car (int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int carryingCapacity, 
            string color, double movementSpeed)
        {
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
        }

    }
}
