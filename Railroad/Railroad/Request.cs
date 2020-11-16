using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Railroad
{
    class Request
    {
        //request class
        //an individual order keeps track of:
        //-the customer information
        //-queue of railcars per order

        public Customer customer = new Customer();
        public Queue<Railcar> train = new Queue<Railcar>();
        public int total = 0;

        //still needs some sort of send request funtion
        public Request()
        {
            Customer customer = new Customer();
        }
        

        public void setCustomerName(string name)
        {
            customer.Customer_name = name;
        }
        public void setCustomerID(int ID)
        {
            customer.Customer_ID = ID;
        }
        public void EnqueueRailcar(Railcar railcar)
        {
            train.Enqueue(railcar);
        }
        public void PriorityEnqueue(Railcar railcar)
        {
            if (train.Count > 0) //if the train is not empty, prepend
                train.Prepend(railcar);
            else
                train.Enqueue(railcar);

        }
        public string GetTotal()
        {
            Railcar current = train.Peek();
            total += current.Charge;
            return total.ToString();
        }
    }
}
