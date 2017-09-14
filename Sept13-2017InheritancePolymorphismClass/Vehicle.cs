using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept13_2017InheritancePolymorphismClass
{
    class Vehicle
    {
        //fields

        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        protected double distanceTraveled;

        private float gearRatio;
        private float engineSize;

        //properties

        public int Seats
        {
            get { return this.seats; }  //no set -- because it's fixed.
        }

        public int CarryingCapacity  //ditto
        {
            get { return this.carryingCapacity; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }

        //constructors

        public Vehicle()
        {

        }

        public Vehicle (int seats, int carryingCapacity, string color, double movementSpeed)
            //reminder: 4 variables are passed to this constructor; 1 is established here.
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            distanceTraveled = 0.0d;
        }

        //methods
        //remember: derived class methods can override base class methods

        public virtual void Move()  //keyword virtual gives derived classes option to override this method
        {
            distanceTraveled += movementSpeed;
        }

        public virtual string GetDistanceTraveled()
        {
            return "Distance Traveled: " + distanceTraveled + "\n";
        }
    }
}
