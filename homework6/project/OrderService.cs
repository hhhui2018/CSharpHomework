using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace project
{
    class OrderService
    {
        private Dictionary<uint, Order> orderDict;
        public OrderService()
        {
            orderDict = new Dictionary<uint, Order>();
        }
        public void AddOrder(Order order)
        {
            if (orderDict.ContainsKey(order.OrderId))
                throw new Exception("order-{order.OrderId} is already existed!");
            orderDict[order.OrderId] = order;
        }
        public void RemoveOrder(uint orderId)
        {
            if (orderDict.ContainsKey(orderId))
            {
                orderDict.Remove(orderId);
            }
        }
        public List<Order> QueryAllOrders()
        {
            return orderDict.Values.ToList();
        }
        public List<Order> QueryOrderById(uint orderId)
        {
            List<Order> result = new List<Order>();
            if (orderDict.ContainsKey(orderId))
            {
                result.Add(orderDict[orderId]);
            }
            return result;
        }
        public List<Order> QueryOrdersByGoodsName(string goodsName)
        {
            List<Order> result = new List<Order>();
            foreach (Order order in orderDict.Values.ToList())
            {
                List<OrderDetail> orderDetailsList = order.QueryAllOrderDetails();
                foreach (OrderDetail od in orderDetailsList)
                {
                    if (od.Goods.GoodsName == goodsName)
                    {
                        result.Add(order);
                        break;
                    }
                }
            }
            return result;
        }
        public List<Order> GetOrdersByCustomerName(string customerName)
        {
            List<Order> result = new List<Order>();
            orderDict.Values.ToList().ForEach(order =>
            {
                if (order.Customer.CustomerName == customerName)
                    result.Add(order);
            });
            return result;
        }
        public void UpdateOrderCustomer(uint orderId, Customer newCustomer)
        {
            if (orderDict.ContainsKey(orderId))
            {
                orderDict[orderId].Customer = newCustomer;
            }
            else
            {
                throw new Exception("order-{orderId} is not existed!");
            }
        }
    }
    public class Person
    {
        public Person() { }
    }
    public class SerializeDemo
    {
        public static void Main2(string[] args)
        {   
            Person[] people =  { new Person() };
            //序列化
            BinaryFormatter binary = new BinaryFormatter();
            String fileName = "s.temp";
            BinarySerialize(binary, fileName, people);
            //反序列化
            Person[] people2 = BinaryDeserialize(binary, fileName) as Person[];
            foreach (Person p in people)
                Console.WriteLine(p);
            //xml 序列化
            XmlSerializer xmlser = new XmlSerializer(typeof(Person[]));
            String xmlFileName = "s.xml";
            XmlSerialize(xmlser, xmlFileName, people);
            //显示 xml 文本
            string xml = File.ReadAllText(xmlFileName);
            Console.WriteLine(xml);
        }
        public static void BinarySerialize(IFormatter formatter, string fileName, object obj)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            formatter.Serialize(fs, obj);
            fs.Close();
        }
        public static object BinaryDeserialize(IFormatter formatter, string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            object obj = formatter.Deserialize(fs);
            fs.Close();
            return obj;
        }
        public static void XmlSerialize(XmlSerializer ser, string fileName, object obj)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create);
            ser.Serialize(fs, obj);
            fs.Close();
        }
    }

}
