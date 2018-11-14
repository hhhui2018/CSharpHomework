using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace homework7
{
    class Customer 
    {
        public Customer(uint id, string name,string phone) {
            CustomerId = id;
            CustomerName = name;
            CustomerPhone = phone;
        }

        public uint CustomerId { get; set; }
                 
        public string CustomerName { get; set; }

        /// <summary>
        /// customer's phone number
        /// </summary>
        public string CustomerPhone { get; set; }

        /// <summary>
        /// 验证手机号
        /// </summary>        
        public static bool IsPhone(string CustomerPhone)
        {
            Regex objReg = new Regex(@"^(\d{00000000000-99999999999}$");
            return objReg.IsMatch(CustomerPhone);
        }

        public override string ToString() {
            return "customerId:{CustomerId}, CustomerName:{CustomerName}";
        }
    }
}
