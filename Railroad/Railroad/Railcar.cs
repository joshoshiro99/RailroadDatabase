using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railroad
{
    class Railcar
    {
        //railcar class
        //maintains all information pertaining a railcar in a request

        //maybe implement a date:time thing for schedule 5-14 car limit??
        private bool pickup;
        private int railcarID;
        private bool priority;

        public Railcar()
        {
        }
        public bool Pickup
        {
            get
            {
                return pickup;
            }
            set
            {
                pickup = value;

            }
        }
        public int Charge { get; set; } = 750;
        public int RailcarID
        {
            get
            {
                return railcarID;
            }
            set
            {
                railcarID = value;
            }
        }
        public bool Priority
        {
            get
            {
                return priority;
            }
            set
            {
                priority = value;
            }
        }
        public int CalculateCharge()
        {
            Charge =  750;
            if (pickup)
            {
                Charge += 300;
            }
            if (priority)
            {
                Charge += 400;
            }
            return Charge;
        }
        public override string ToString()
        {
             return "Car ID: " + railcarID +"\t" +"Pickup: " + pickup +"\t" + "  Priority: " + priority +"\t" + "Amount Due: $"+ CalculateCharge();
        }
    }
}
