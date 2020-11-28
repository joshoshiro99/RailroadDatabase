using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railroad
{
    class Customer
    {
        //customer class
        //records all information about a customer

        //request delivery/pickup functions??

        private readonly string customer_name;
        private readonly int customer_ID;

        public Customer()
        {

        }
        public string Customer_name { get; set; }
        public int Customer_ID { get; set; }
        public override string ToString() => $"({Customer_ID}: {Customer_name})";
    }
}
