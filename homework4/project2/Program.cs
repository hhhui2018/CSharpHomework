using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace program2
{
    public class OrderTest
    {
        public struct Order : IComparable
        {
            public int Num;
            public int Price;
            public int Amount;
            public string TradeName;
            public string CustomerName;
            public Order(int num, int price, int amount, string tradeName, string customerName)
            {
                this.Num = num;
                this.Price = price;
                this.Amount = amount;
                this.TradeName = tradeName;
                this.CustomerName = customerName;        
            }
            public int CompareTo(object obj2)
            {
                if (!(obj2 is Order))
                    throw new System.ArgumentException();
                Order rec2 = (Order)obj2;
                if (this.Num > rec2.Num) return 1;
                else if (this.Num == rec2.Num) return 0;
                return -1;
            }
            public override string ToString()
            {
                return  "Num:" + Num + "\tPrice:" + Price + "\tAmount:" + Amount + "\tCustomerName:" + CustomerName + "\tTradeName:" + TradeName;
            }
        }

        public class MyComparer : IComparer
        {
            public int Compare(object obj1, object obj2)
            {
                if (!(obj2 is Order) || !(obj2 is Order))
                    throw new System.ArgumentException();
                Order rec1 = (Order)obj1;
                Order rec2 = (Order)obj2;
                return rec1.CustomerName.ToLower().CompareTo(rec2.CustomerName.ToLower());
            }
        }

        public static void PrintKeysAndValues(SortedList myList)
        {
            IDictionaryEnumerator myEunmerator = myList.GetEnumerator();
            while (myEunmerator.MoveNext())
                Console.WriteLine("\t{0}:\t\t{1}",
            myEunmerator.Key, myEunmerator.Value);
            Console.WriteLine();
        }
        public static void Main()
        {
            Order o1 = new Order(20181001, 34, 10, "Candies", "Lily");
            Order o2 = new Order(20181002, 520, 1, "Electric Cooker", "Tom");
            Order o3 = new Order(20181003, 76, 2, "Jacket", "Elizabeth" );
            Order o4 = new Order(20181004, 1999, 1, "Mobile Phone", "Jackson");
            Order [] MyOrders = { o1, o2, o3, o4 };

            Order o5 = new Order(20181002, 520, 1, "Electric Cooker", "Tom");
            o5 = o2;
            int i = Array.BinarySearch<Order>(MyOrders, o5);
            Console.WriteLine(o5);



            Random rnd = new Random();
            SortedList list1 = new SortedList();
            foreach (Order r in MyOrders)
                list1.Add(r, "Room:" + rnd.Next(1000));
            PrintKeysAndValues(list1);

            SortedList list2 =
                new SortedList(list1, new MyComparer());
            PrintKeysAndValues(list2);

        }
    }
}

