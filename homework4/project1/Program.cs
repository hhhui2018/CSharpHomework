using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
     class Clock
    {
         int hour, min, sec;
         int chour, cmin, csec;
        public event EventHandler ring;
        protected virtual void OnRing()
        {
            EventHandler temp = ring;
            if (temp != null) temp(this,EventArgs.Empty);
        }
        public void setTime(int hour,int min,int sec)
        {
            this.hour = hour;
            this.min = min;
            this.sec = sec;
        }
         public void setClock(int hour,int min,int sec)
         {
             this.chour = hour;
             this.cmin = min;
             this.csec = sec;
         }
         public void checkClock()
         {
             if ((sec == csec) && (min == cmin) && (hour == chour))
             {
                 Console.WriteLine("Ringing");
                 OnRing(); 
             }
         }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Clock();
            myClock.setTime(6, 10, 0);
            myClock.setClock(6, 10, 0);
            myClock.checkClock(); 
        }
    }  
}
