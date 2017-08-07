using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow
{
   public  class Time
    {


        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
       // public object Hours { get; private set; }

        public override string ToString()
        {
            return String.Format(
                "{0:00}:{1:00}:{2:00}",
                this.Hours, this.Minutes, this.Seconds);
        }



    }
}
