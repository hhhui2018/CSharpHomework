using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Order 
    {
        private Dictionary<uint, OrderDetail> orderDetailsDict;
        public Order(uint orderId, Customer customer) {
            OrderId = orderId;
            Customer = customer;
            orderDetailsDict = new Dictionary<uint, OrderDetail>();
        }
        public uint OrderId { get; set; }
        public Customer Customer { get; set; }
        public void AddOrderDetail(OrderDetail orderDetail) {
            if (orderDetailsDict.ContainsKey(orderDetail.OrderDetailId))  {
                throw new Exception("orderDetails-{orderDetail.OrderDetailId} is already existed!");
            } else {
                orderDetailsDict[orderDetail.OrderDetailId] = orderDetail;
            }
        }
        public void RemoveOrderDetail(uint orderDetailId) {
            if (orderDetailsDict.ContainsKey(orderDetailId)) {
                orderDetailsDict.Remove(orderDetailId);
            } else {
                throw new Exception("orderDetails-{orderDetailId} is not existed!");
            }
        }
        public List<OrderDetail> QueryAllOrderDetails() {
            return orderDetailsDict.Values.ToList();
        }
        public override string ToString() {
            string result = "================================================================================\n";
            result += "orderId:{OrderId}, customer:({Customer})";
            orderDetailsDict.Values.ToList().ForEach(od => result += "\n\t" + od);
            result += "\n================================================================================";
            return result;
        }
    }
}
