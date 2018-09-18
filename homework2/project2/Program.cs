using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; 

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 43, 6, 23, 55, 12, 7 };
            if (arr == null) throw new Exception("数组空异常");
            //最小值
            int value = 0;
            bool hasValue = false;
            foreach (int x in arr)
            {
                if (hasValue)
                {
                    if (x < value) value = x;
                }
                else
                {
                    value = x;
                    hasValue = true;
                }
            }
            if (hasValue) 
                Console.WriteLine("Min:"+value);
            else 
                throw new Exception("没找到");
            //最大值
            int value2 = 0;
            bool bValue = false;
            foreach (int x in arr)
            {
                if (bValue)
                {
                    if (x > value2) value2 = x;
                }
                else
                {
                    value2 = x;
                    bValue = true;
                }
            }
            if (bValue) 
                Console.WriteLine("Max:"+ value2);
            else 
                throw new Exception("没找到");
            //求和+求平均值
            if (arr == null) throw new Exception("数组空异常");
            long sum = 0;
            long count = 0;
            checked
            {
                foreach (int? v in arr)
                {
                    if (v != null)
                    {
                        sum += v.GetValueOrDefault();
                        count++;
                    }
                }
            }
            if (count > 0) 
                Console.WriteLine("Add:"+sum+"    Average:"+(sum/count) );
            else throw new Exception("有错误！");
        }
    }
}
