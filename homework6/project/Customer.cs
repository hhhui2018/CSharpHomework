using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Customer
    {
        public Customer(uint id, string name)
        {
            CustomerId = id;
            CustomerName = name;
        }
        public uint CustomerId { get; set; }
        public string CustomerName { get; set; }
        public override string ToString()
        {
            return "customerId:{CustomerId}, CustomerName:{CustomerName}";
        }
    }
}
