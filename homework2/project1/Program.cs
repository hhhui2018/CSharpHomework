using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number:");
            string snum = Console.ReadLine();
            int num;
            try
            {
                num = int.Parse(snum);
            }
            catch (Exception e)
            {
                throw e;
            }
            int i = 2;
            while (i <= num)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                    num = num / i;
                    while (num % i == 0)
                        num = num / i;
                }
                else
                    i++;
            }
        }
    }
}
