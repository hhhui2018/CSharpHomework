using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class OrderDetail 
    {
        public OrderDetail(uint orderDetailId, Goods goods, uint quantity) {
            OrderDetailId = orderDetailId;
            Goods = goods;
            Quantity = quantity;
        }
        public uint OrderDetailId { get; set; }
        public Goods Goods { get; set; }
        public uint Quantity { get; set; }
        public override string ToString() {
            string result = "";
            result += "orderDetailId:{OrderDetailId}:  ";
            result += Goods + ", quantity:{Quantity}"; 
            return result;
        }
    }
}