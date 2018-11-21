using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace homework7 
{

    class OrderService 
    {
        private Dictionary<uint, Order> orderDict;

        public OrderService() {
            orderDict = new Dictionary<uint, Order>();
        }

        public void AddOrder(Order order) {
            if (orderDict.ContainsKey(order.OrderId))
                throw new Exception("order-{order.OrderId} is already existed!");
            orderDict[order.OrderId] = order;
        }

        public void RemoveOrder(uint orderId) {
            if (orderDict.ContainsKey(orderId)) {
                orderDict.Remove(orderId);
            }
        }

        public List<Order> QueryAllOrders() {
            return orderDict.Values.ToList();
        }

        public List<Order> QueryOrderById(uint orderId) {
            List<Order> result = new List<Order>();
            if (orderDict.ContainsKey(orderId)){
                result.Add(orderDict[orderId]);
            }
            //数据验证，查看订单号
            string res = orderId.ToString();
            bool l = Regex.IsMatch(res, @"^(\d{2018}$|^\d{12}$|^\d{31}^\d{999})$");
            if (l == true)
            {
                return result;
            }
            else
            {
                Console.WriteLine("匹配错误");
                return null;
            }          
        }

        public List<Order> QueryOrdersByGoodsName(string goodsName) {
            List<Order> result = new List<Order>();
            foreach (Order order in orderDict.Values.ToList()) {
                List<OrderDetail> orderDetailsList = order.QueryAllOrderDetails();
                foreach(OrderDetail od in orderDetailsList) {
                    if(od.Goods.GoodsName == goodsName) {
                        result.Add(order);
                        break;
                    }
                }
            }
            return result;
        }

        public List<Order> GetOrdersByCustomerName(string customerName) {
            List<Order> result = new List<Order>();
            orderDict.Values.ToList().ForEach(order => {
                if (order.Customer.CustomerName == customerName)
                    result.Add(order);
            });
            return result;
        }

        public void UpdateOrderCustomer(uint orderId, Customer newCustomer) {
            if (orderDict.ContainsKey(orderId)) {
                orderDict[orderId].Customer = newCustomer;
            } else {
                throw new Exception("order-{orderId} is not existed!");
            }
        }

        /*other update function will write in the future.*/
    }
}
